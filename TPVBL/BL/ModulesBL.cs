using TPVDAL.DAL;
using TPVModels.Models.Modules;

namespace TPVBL.BL;

public class ModulesBL
{
    
    private readonly ModulesDAL DAO = new ModulesDAL();

    public async Task<List<SPGetModulesByUser>> GetModulesByUser(int idUser)
    {
        return await DAO.GetModulesByUser(idUser);
    }
    
}