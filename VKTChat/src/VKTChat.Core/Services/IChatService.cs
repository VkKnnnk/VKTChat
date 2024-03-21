using VKTChat.Core.Models;

namespace VKTChat.Core.Services
{
    public interface IChatService
    {
        void SendMessage(Message message);
        void DeleteMessage(Message message);
        void EditMessage(Message message);
        void GoBack();
    }
}
