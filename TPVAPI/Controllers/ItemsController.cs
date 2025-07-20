using Microsoft.AspNetCore.Mvc;
using TPVBL.BL;
using TPVModels.Models.Items.SPs;

namespace TPVAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ItemsController: ControllerBase
{
    
    private readonly ItemsBL BL = new ItemsBL();

    [HttpGet]
    [Route("GetItemsByUser")]
    public async Task<List<SP_GET_ITEMS_BY_USER>> GetItemsByUser(int idUser)
    {
        return await BL.GetItemsByUser(idUser);
    }

}