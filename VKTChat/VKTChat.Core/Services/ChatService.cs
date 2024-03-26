using VKTChat.Core.Models;

namespace VKTChat.Core.Services
{
    public class ChatService : IChatService
    {
        #region Properties
        private User _currentUser;
        private List<Chat> _chats;
        #endregion
        #region Services
        private readonly IDataContext _userContext;
        private readonly IAppdataService _appdataService;
        #endregion
        public ChatService(IDataContext dataContext, IAppdataService appdataService)
        {
            _userContext = dataContext;
            _appdataService = appdataService;
            var currentUser = _userContext.GetCurrentData();
            if (currentUser is not User || currentUser is null)
                throw new ArgumentException("СurrentUser must be a valid instance of User", nameof(currentUser));
            _currentUser = currentUser as User;
            _chats = _currentUser.Chats;
        }
        #region Methods
        public List<Chat> GetChats() => _chats;
        public async Task AddChatAsync(Chat newChat)
        {
            var nextId = _chats.Any() ? _chats.Max(u => u.IdChat) + 1 : 1;
            newChat.IdChat = nextId;
            _chats.Add(newChat);
            await _appdataService.SaveDataAsync();
        }
        public async Task EditChatAsync(int idChat, Chat newChat)
        {
            Chat? chatToEdit = _chats.FirstOrDefault(x => x.IdChat == idChat);
            if (chatToEdit is null)
                throw new InvalidOperationException($"Chat with ID {idChat} not found");
            chatToEdit.Name = newChat.Name;
            await _appdataService.SaveDataAsync();
        }
        public async Task DeleteChatAsync(int idChat)
        {
            if (_chats.Any(u => u.IdChat == idChat))
            {
                _chats.RemoveAll(u => u.IdChat == idChat);
                await _appdataService.SaveDataAsync();
            }
            else
                throw new InvalidOperationException($"Chat with ID {idChat} not found");
        }

        public Chat? GetChatById(int idChat)
        {
            Chat? chat = _chats.FirstOrDefault(x => x.IdChat == idChat);
            if (chat is null)
                throw new InvalidOperationException($"User with ID {idChat} not found");
            return chat;
        }
        #endregion
    }
}
