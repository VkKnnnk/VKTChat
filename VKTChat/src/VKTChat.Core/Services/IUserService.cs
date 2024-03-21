using VKTChat.Core.Models;

namespace VKTChat.Core.Services
{
    public interface IUserService
    {
        void CreateUser(User newUser);
        void EditUser(User selectedUser);
        void DeleteUser(User selectedUser);
    }
}
