using TPVDAL.DAL;
using TPVModels.Models.Items.SPs;
using TPVModels.Models.Items.Tables;

namespace TPVBL.BL;

public class ItemsBL
{

    private readonly ItemsDAL DAO = new ItemsDAL();
    
    public async Task<List<SP_GET_ITEMS_BY_USER>> GetItemsByUser(int idUser)
    {
        return await DAO.GetItemsByUser(idUser);
    }

    public async Task<bool> ChangeItemStatus(int idUser, int idItem, int idStatus)
    {
        return await DAO.ChangeItemStatus(idUser, idItem, idStatus);
    }

    public async Task<bool> UpdateItem(CAT_ITEMS payload)
    {
        return await DAO.UpdateItem(payload);
    }

}