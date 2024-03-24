using VKTChat.Core.Models;

namespace VKTChat.Core.Services
{
    public interface IChatService
    {
        Chat? CreateChat(Chat newChat);
        bool EditChat(int idChat, Chat newChat);
        bool DeleteChat(int idChat);
        List<Chat> GetChats();
        Chat? GetChat(int idChat);
    }
}
