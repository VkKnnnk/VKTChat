using VKTChat.Core.Models;

namespace VKTChat.Core.Services
{
    public interface IUserService
    {
        void RegistrateUser(User newData);
        bool LoginUser(string username, string password);
        void EditUser(int idUser, User newData);
        void DeleteUser(int idUser);
        User GetUser(int idUser);
    }
}
