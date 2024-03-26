using VKTChat.Core.Models;

namespace VKTChat.Core.Services
{
    public class MessageService : IMessageService
    {
        private readonly IAppdataService _appdataService;
        public MessageService(IAppdataService appdataService)
        {
            _appdataService = appdataService;
        }
        public bool DeleteMessage(int idMessage)
        {
            throw new NotImplementedException();
        }

        public bool EditMessage(int idMessage, Message newMessage)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetMessages()
        {
            throw new NotImplementedException();
        }

        public void SendMessage(Message newMessage)
        {
            throw new NotImplementedException();
        }
    }
}
