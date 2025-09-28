using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TPVBL.BL;

namespace TPVAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class UnitsMeasureController: ControllerBase
{
    
    private readonly UnitsMeasureBL BL = new UnitsMeasureBL();
    
    [HttpGet]
    [Route("GetUnitMeasures")]
    public async Task<IActionResult> GetUnitMeasures()
    {
        try
        {
            return Ok(await BL.GetUnitMeasures());

        }
        catch (Exception ex)
        {
            
            return BadRequest(ex.Message);
            
        }
        
    }
    
}