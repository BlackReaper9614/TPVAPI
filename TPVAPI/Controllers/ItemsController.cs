using Microsoft.AspNetCore.Mvc;
using TPVBL.BL;
using TPVModels.Models.Items.SPs;
using TPVModels.Models.Items.Tables;

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

    [HttpPost]
    [Route("ChangeItemStatus")]
    public async Task<bool> ChangeItemStatus(int idUser, int idItem, int idStatus)
    {
        return await BL.ChangeItemStatus(idUser, idItem, idStatus);
    }

    [HttpPost]
    [Route("UpdateItem")]
    public async Task<bool> UpdateItem(CAT_ITEMS payload)
    {
        return await BL.UpdateItem(payload);
    }

}