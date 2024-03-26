using VKTChat.Core.Models;

namespace VKTChat.Core.Services
{
    public interface IUserService
    {
        User? GetUserByID(int idUser);
        Task AddUserAsync(User newUser);
        Task EditUserAsync(int idUser, User newData);
        Task DeleteUserAsync(int idUser);
    }
}
