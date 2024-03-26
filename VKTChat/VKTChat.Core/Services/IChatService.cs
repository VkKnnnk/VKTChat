using VKTChat.Core.Models;

namespace VKTChat.Core.Services
{
    public interface IChatService
    {
        List<Chat> GetChats();
        Task AddChatAsync(Chat newChat);
        Task EditChatAsync(int idChat, Chat newChat);
        Task DeleteChatAsync(int idChat);
        Chat? GetChatById(int idChat);
    }
}
