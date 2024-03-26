using VKTChat.Core.Models;

namespace VKTChat.Core.Services
{
    public interface IAppdataService
    {
        Task<List<User>> GetDataAsync();
        Task SaveDataAsync();
    }
}
