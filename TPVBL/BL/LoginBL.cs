using TPVDAL.DAL;
using TPVModels.Models.Users;

namespace TPVBL.BL;

public class LoginBL
{

    private readonly LoginDAL DAO = new LoginDAL();

    public async Task<User> GetUserByCredentials(User payload)
    {
        return await DAO.GetUserByCredentials(payload);
    }

}