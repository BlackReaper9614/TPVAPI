using TPVDAL.DAL;
using TPVModels.Models.Items.SPs;

namespace TPVBL.BL;

public class ItemsBL
{

    private readonly ItemsDAL DAO = new ItemsDAL();
    
    public async Task<List<SP_GET_ITEMS_BY_USER>> GetItemsByUser(int idUser)
    {
        return await DAO.GetItemsByUser(idUser);
    }

}