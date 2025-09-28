using TPVDAL.DAL;
using TPVModels.Models.Families.Tables;

namespace TPVBL.BL;

public class FamiliesBL
{
    
    public readonly FamiliesDAL DAO = new FamiliesDAL();

    public async Task<IEnumerable<CAT_FAMILIES>> GetFamilies()
    {
        return await DAO.GetFamilies();
    }
    
}