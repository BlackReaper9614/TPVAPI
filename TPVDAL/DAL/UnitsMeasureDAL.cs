using System.Data;
using Microsoft.Extensions.Configuration;
using Dapper;
using Microsoft.Data.SqlClient;
using TPVModels.Models.UnitsMeasure.Tables;

namespace TPVDAL.DAL;

public class UnitsMeasureDAL
{
    private readonly string _connectionString;

    public UnitsMeasureDAL()
    {
        var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json").Build();

        _connectionString = builder.GetSection("ConnectionStrings:DefaultConnection").Value;
    }

    public async Task<IEnumerable<CAT_UNIT_MEASURES>> GetUnitMeasures()
    {
        string method = "GetUnitMeasures";

        string SP = "SP_GET_UNIT_MEASURES";

        IEnumerable<CAT_UNIT_MEASURES> result = new List<CAT_UNIT_MEASURES>();

        using (SqlConnection conn = new SqlConnection(_connectionString))
        {
            result = await conn.QueryAsync<CAT_UNIT_MEASURES>
            (
                SP,
                commandType: CommandType.StoredProcedure
            );
        }

        return result;
    }
    
}