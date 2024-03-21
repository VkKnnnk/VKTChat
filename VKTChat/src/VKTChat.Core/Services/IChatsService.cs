using VKTChat.Core.Models;

namespace VKTChat.Core.Services
{
    public interface IChatsService
    {
        void CreateChat(Chat newChat);
        void EditChat(Chat selectedChat);
        void DeleteChat(Chat selectedChat);
        void OpenChat(Chat selectedChat);
    }
}
