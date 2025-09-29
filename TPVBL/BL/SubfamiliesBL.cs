using TPVDAL.DAL;
using TPVModels.Models.Subfamilies.Tables;

namespace TPVBL.BL;

public class SubfamiliesBL
{

    private readonly SubfamiliesDAL DAO = new SubfamiliesDAL();
    
    public async Task<IEnumerable<CAT_SUBFAMILIES>> GetSubfamilies()
    {
        return await DAO.GetSubfamilies();
    }
    
    public async Task<IEnumerable<CAT_SUBFAMILIES>> GetSubfamiliesByFamily(int idFamily)
    {
        return await DAO.GetSubfamiliesByFamily(idFamily);
    }

}