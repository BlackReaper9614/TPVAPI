using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TPVBL.BL;

namespace TPVAPI.Controllers;

[Authorize]
[Route("api/[controller]")]
public class SubfamiliesController: ControllerBase
{
    
    private readonly SubfamiliesBL BL = new SubfamiliesBL();
    
    [HttpGet]
    [Route("Getsubfamilies")]
    public async Task<IActionResult> GetSubfamilies()
    {
        try
        {
            return Ok( await BL.GetSubfamilies() );
        }
        catch (Exception ex)
        {
            return BadRequest( ex.Message );
        }
        
    }
    
    [HttpGet]
    [Route("GetSubfamiliesByFamily")]
    public async Task<IActionResult> GetSubfamiliesByFamily(int idFamily)
    {
        
        try
        {
            return Ok( await BL.GetSubfamiliesByFamily(idFamily) );
        }
        catch (Exception ex)
        {
            return BadRequest( ex.Message );
        }
        
    }

}