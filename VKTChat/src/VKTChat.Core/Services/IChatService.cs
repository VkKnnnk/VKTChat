using VKTChat.Core.Models;

namespace VKTChat.Core.Services
{
    public interface IChatService
    {
        bool CreateChat(Chat newData);
        bool EditChat(int idChat, Chat newData);
        bool DeleteChat(int idChat);
        Chat GetChat(int idChat);
    }
}
