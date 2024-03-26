using VKTChat.Core.Models;

namespace VKTChat.Core.Services
{
    public class ChatService : IChatService
    {
        private List<Chat> _chats;
        private readonly IAppdataService _appdataService;
        public ChatService(IAppdataService appdataService)
        {
            _appdataService = appdataService;
        }
        public Chat? CreateChat(Chat newChat)
        {
            throw new NotImplementedException();
        }

        public bool DeleteChat(int idChat)
        {
            throw new NotImplementedException();
        }

        public bool EditChat(int idChat, Chat newChat)
        {
            throw new NotImplementedException();
        }

        public Chat? GetChat(int idChat)
        {
            throw new NotImplementedException();
        }

        public List<Chat> GetChats()
        {
            return _chats;
        }
    }
}
