using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using TPVBL.BL;
using TPVModels.Models.Modules;

namespace TPVAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class ModulesController: ControllerBase
{
    
    private readonly ModulesBL BL = new ModulesBL();

    [Microsoft.AspNetCore.Mvc.HttpGet]
    [Route("GetModulesByUser")]
    public async Task<List<SPGetModulesByUser>> GetModulesByUser(int idUser)
    {
        return await BL.GetModulesByUser(idUser);
    }
    
} 