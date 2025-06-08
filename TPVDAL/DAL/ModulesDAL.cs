using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using TPVModels.Models.Modules;

namespace TPVDAL.DAL;

public class ModulesDAL
{
    
    private readonly string _className = "ModulesDAL";
    
    private readonly string _connectionString;

    public ModulesDAL()
    {
        var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

        _connectionString = builder.GetSection("ConnectionStrings:DefaultConnection").Value;
    }

    public async Task<List<SPGetModulesByUser>> GetModulesByUser(int idUser)
    {
        string methodName = "GetModulesByUser";
        
        string SP = "SP_GET_MODULES_BY_USER";

        List<SPGetModulesByUser> result = new List<SPGetModulesByUser>();
        
        try
        {

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                
                result = (await conn.QueryAsync<SPGetModulesByUser>(
                    SP,
                    new
                    {
                        idUser = idUser
                    },
                    commandType: System.Data.CommandType.StoredProcedure
                )).ToList();

            }
            
        }
        catch (Exception ex)
        {

            
            
        }
        
        return result;
    }

}