using VKTChat.Core.Models;

namespace VKTChat.Core.Services
{
    public interface IUserService
    {
        User RegistrateUser(User newData);
        User? LoginUser(string username, string password);
        bool EditUser(int idUser, User newData);
        bool DeleteUser(int idUser);
        List<User> GetUsers();
    }
}
