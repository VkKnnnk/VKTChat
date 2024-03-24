using System;
using System.Collections.Generic;
using VKTChat.Core.Models;

namespace VKTChat.Core.Services
{
    internal class MessageService : IMessageService
    {
        public void DeleteMessage(int messageId)
        {
            throw new NotImplementedException();
        }

        public bool EditMessage(int idMessage, Message newData)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetMessages(int idChat)
        {
            throw new NotImplementedException();
        }

        public void SendMessage(int idChat, Message newData)
        {
            throw new NotImplementedException();
        }
    }
}
