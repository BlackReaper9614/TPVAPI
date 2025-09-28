using TPVDAL.DAL;
using TPVModels.Models.UnitsMeasure.Tables;

namespace TPVBL.BL;

public class UnitsMeasureBL
{

    public readonly UnitsMeasureDAL DAO = new UnitsMeasureDAL();
    
    public async Task<IEnumerable<CAT_UNIT_MEASURES>> GetUnitMeasures()
    {
        return await DAO.GetUnitMeasures();
    }

}