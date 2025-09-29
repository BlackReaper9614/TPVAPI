using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using TPVModels.Models.Subfamilies.Tables;

namespace TPVDAL.DAL;

public class SubfamiliesDAL
{
    
    private readonly string _className = "SubfamiliesDAL";

    private readonly string _connectionString;
    
    public SubfamiliesDAL()
    {
        var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
        
        _connectionString = builder.GetSection("ConnectionStrings:DefaultConnection").Value;
    }

    public async Task<IEnumerable<CAT_SUBFAMILIES>> GetSubfamilies()
    {
        string methodName = "GetSubfamilies";

        string SP = "SP_GET_SUBFAMILIES";

        IEnumerable<CAT_SUBFAMILIES> result = new List<CAT_SUBFAMILIES>();

        using (SqlConnection conn = new SqlConnection(_connectionString))
        {

            result = await conn.QueryAsync<CAT_SUBFAMILIES>
                (
                    SP,
                    commandType: CommandType.StoredProcedure
                );
            
        }

        return result;
    }    
    
    public async Task<IEnumerable<CAT_SUBFAMILIES>> GetSubfamiliesByFamily(int idFamily)
    {
        string methodName = "GetSubfamilies";

        string SP = "SP_GET_SUBFAMILIES_BY_FAMILY";

        IEnumerable<CAT_SUBFAMILIES> result = new List<CAT_SUBFAMILIES>();

        using (SqlConnection conn = new SqlConnection(_connectionString))
        {

            result = await conn.QueryAsync<CAT_SUBFAMILIES>
                (
                    SP,
                    new
                    {
                        idFamily = idFamily
                    },
                    commandType: CommandType.StoredProcedure
                );
            
        }

        return result;
    }
    
}