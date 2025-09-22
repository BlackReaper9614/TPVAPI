using System.Data;
using Microsoft.Extensions.Configuration;
using Dapper;
using Microsoft.Data.SqlClient;
using TPVModels.Models.Items.Entities;
using TPVModels.Models.Items.SPs;
using TPVModels.Models.Items.Tables;

namespace TPVDAL.DAL;

public class ItemsDAL
{
    private readonly string _className = "ItemsDAL";

    private readonly string _connectionString;

    public ItemsDAL()
    {
        var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json").Build();

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
                        idUser = userId,
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

    public async Task<bool> ChangeItemStatus(int idUser, int idItem, int idStatus)
    {
        string methodName = "ChangeItemStatus";

        string SP = "SP_CHANGE_ITEM_STATUS";

        bool result = false;

        try
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                result = await connection.QuerySingleAsync<bool>(
                    SP,
                    new
                    {
                        idUser = idUser,
                        idItem = idItem,
                        idStatus = idStatus,
                    },
                    commandType: CommandType.StoredProcedure
                );
            }
        }
        catch (Exception ex)
        {
        }

        return result;
    }

    public async Task<bool> UpdateItem(CAT_ITEMS payload)
    {
        string methodName = "UpdateItem";

        string SP = "SP_UPDATE_ITEM";

        bool result = false;

        try
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                result = await connection.QuerySingleAsync<bool>(
                    SP,
                    new
                    {
                        idUser = payload.idUser,
                        idItem = payload.idItem,
                        itemCodebar = payload.itemCodebar,
                        itemName = payload.itemName,
                        purchaseCost = payload.purchaseCost,
                        sellCost = payload.sellCost,
                        itemBrand = payload.itemBrand,
                        itemModel = payload.itemModel,
                        stock = payload.stock,
                        idUnitMeasure = payload.idUnitMeasure,
                        idSubfamily = payload.idSubfamily,
                        idStatus = payload.idStatus
                    },
                    commandType: CommandType.StoredProcedure
                );
            }
        }
        catch (Exception ex)
        {
        }

        return result;
    }

    public async Task<IEnumerable<CAT_ITEMS>> GetItemsByParams(QueryParams payload)
    {
        string methodName = "GetItemsByParams";

        string SP = "SP_GET_ITEMS_BY_PARAMS";

        IEnumerable<CAT_ITEMS> result = new List<CAT_ITEMS>();
        
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            result = await connection.QueryAsync<CAT_ITEMS>(
                SP,
                new
                {
                    idUser = payload.idUser,
                    parameterType = payload.parameterType,
                    searchParameters = payload.searchParameters,
                    currentPage = payload.currentPage,
                    pageSize = payload.pageSize,
                },
                commandType: CommandType.StoredProcedure
            );
        }

        return result;
    }
    
}