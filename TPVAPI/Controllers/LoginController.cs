using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using TPVBL.BL;
using TPVModels.Models.Users;

namespace TPVAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LoginController : ControllerBase
{

    private readonly IConfiguration _configuration;

    public LoginController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    private readonly LoginBL BL = new LoginBL();
    
    [HttpPost]
    [Route("Auth")]
    public async Task<IActionResult> Auth([FromBody] User payload)
    {
        User user = await BL.GetUserByCredentials(payload);

        if (user.idUser <= 0) return Unauthorized();
        
        user.authToken = GenerateJwt(user.userName);

        return Ok(user);
    }

    [Authorize]
    [HttpPost]
    [Route("RenewToken")]
    public IActionResult RenewToken([FromBody] User payload)
    {
        
        try
        {
            payload.authToken = GenerateJwt(payload.userName);
            
            return Ok(payload);
        }
        catch (Exception ex)
        {
            return Unauthorized($"El token recibido no es valido, Error = {ex.Message}");
        }
        
    }

    private string GenerateJwt(string userName)
    {
        var jwtSettings = _configuration.GetSection("JWTSettings");
        
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["Key"] ?? string.Empty));
        
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        
        var claims = new[]
        {
            new Claim(ClaimTypes.Name, userName)
        };
        
        var token = new JwtSecurityToken(
                issuer: jwtSettings["Issuer"],
                audience: jwtSettings["Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(Convert.ToDouble(jwtSettings["ExpirationMinutes"])),
                signingCredentials: credentials
            );

        string tokenString = new JwtSecurityTokenHandler().WriteToken(token);

        return tokenString;
    }

}