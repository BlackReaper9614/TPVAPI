using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TPVBL.BL;

namespace TPVAPI.Controllers;

[ApiController]
[Authorize]
[Route("api/[controller]")]
public class FamiliesController: ControllerBase
{

    public readonly FamiliesBL BL = new FamiliesBL();
    
    [HttpGet]
    [Route("GetFamilies")]
    public async Task<IActionResult> GetFamilies()
    {

        try
        {

            return Ok(await BL.GetFamilies());
            
        }
        catch (Exception ex)
        {

            return BadRequest(ex.Message);

        }
        
    }
    
}