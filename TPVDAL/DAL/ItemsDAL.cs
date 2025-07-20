using System.Data;
using Microsoft.Extensions.Configuration;
using Dapper;
using Microsoft.Data.SqlClient;
using TPVModels.Models.Items.SPs;

namespace TPVDAL.DAL;

public class ItemsDAL
{
    
    private readonly string _className = "ItemsDAL";

    private readonly string _connectionString;
    
    public ItemsDAL()
    {
        var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
        
        _connectionString = builder.GetSection("ConnectionStrings:DefaultConnection").Value;
    }

    public async Task<List<SP_GET_ITEMS_BY_USER>> GetItemsByUser(int userId)
    {
        string methodName = "GetItemsByUser";

        string SP = "SP_GET_ITEMS_BY_USER";

        List<SP_GET_ITEMS_BY_USER> result = new List<SP_GET_ITEMS_BY_USER>(); 
        
        try
        {

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                 result = (await connection.QueryAsync<SP_GET_ITEMS_BY_USER>(
                    SP,
                    new
                    {
                        idUser =  userId,
                    },
                    commandType: CommandType.StoredProcedure
                 )).ToList();
                
            }

        }
        catch (Exception ex)
        {
            
        }
        
        return result;
    }

}