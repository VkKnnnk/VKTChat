using System.Collections.Generic;
using VKTChat.Core.Models;

namespace VKTChat.Core.Services
{
    public interface IMessageService
    {
        void SendMessage(Message newMessage);
        bool EditMessage(int idMessage, Message newMessage);
        bool DeleteMessage(int idMessage);
        List<Message> GetMessages();
    }
}
