using System.Data;
using Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using TPVModels.Models.Users;

namespace TPVDAL.DAL;

public class LoginDAL
{
    
    private readonly string _className = "LoginDAL";

    private readonly string? _connectionString;

    public LoginDAL()
    {
        var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
        
        _connectionString = builder.GetSection("ConnectionStrings:DefaultConnection").Value;;
    }

    public async Task<User> GetUserByCredentials(User payload)
    {
        string methodName = "GetUserByCredentials";

        string SP = "SP_GET_USER_BY_CREDENTIALS";
        
        try
        {

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                payload = await con.QuerySingleAsync<User>(
                    SP,
                    new
                    {
                        userName = payload.userName,
                        userPassword = payload.userPassword,
                    },
                    commandType: CommandType.StoredProcedure
                );

            }

        }
        catch (Exception ex)
        {
    
        }

        return payload;
    }

}