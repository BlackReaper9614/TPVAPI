using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using TPVModels.Models.Families.Tables;

namespace TPVDAL.DAL;

public class FamiliesDAL
{
    private readonly string _connectionString;

    public FamiliesDAL()
    {
        var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

        _connectionString = builder.GetSection("ConnectionStrings:DefaultConnection").Value;
    }

    public async Task<IEnumerable<CAT_FAMILIES>> GetFamilies()
    {
        string method = "GetFamilies";

        string SP = "SP_GET_FAMILIES";

        IEnumerable<CAT_FAMILIES> result = new List<CAT_FAMILIES>();

        using (SqlConnection conn = new SqlConnection(_connectionString))
        {
            result = await conn.QueryAsync<CAT_FAMILIES>
            (
                SP,
                commandType: CommandType.StoredProcedure
            );
        }

        return result;
    }
    
}