using System.Collections.Generic;
using VKTChat.Core.Models;

namespace VKTChat.Core.Services
{
    public interface IMessageService
    {
        void SendMessage(int idChat, Message newData);
        bool EditMessage(int idMessage, Message newData);
        void DeleteMessage(int messageId);
        List<Message> GetMessages(int idChat);
    }
}
