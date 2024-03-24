using VKTChat.Core.Models;

namespace VKTChat.Core.Services
{
    public interface IBotService
    {
        void EnqueueMessage(Message message);
        void ProcessMessages();
        Message ProcessMessage(Message message);
        void SendMessageToUser(int idChat, Message response);
    }
}
