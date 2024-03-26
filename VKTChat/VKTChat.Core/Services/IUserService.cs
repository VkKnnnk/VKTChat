using VKTChat.Core.Models;

namespace VKTChat.Core.Services
{
    public interface IUserService
    {
        List<User> GetUsers();
        Task AddUserAsync(User newUser);
        Task EditUserAsync(int idUser, User newData);
        Task DeleteUserAsync(int idUser);
        User? GetUserById(int idUser);
    }
}
