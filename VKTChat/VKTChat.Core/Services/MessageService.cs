using VKTChat.Core.Models;

namespace VKTChat.Core.Services
{
    public class MessageService : IMessageService
    {
        #region Properties
        private Chat _currentChat;
        private List<Message> _messages;
        #endregion
        #region Services
        private readonly IDataContext _chatContext;
        private readonly IAppdataService _appdataService;
        #endregion
        public MessageService(IDataContext dataContext, IAppdataService appdataService)
        {
            _chatContext = dataContext;
            _appdataService = appdataService;

            var currentChat = _chatContext.GetCurrentData();
            if (currentChat is not Chat or null)
                throw new ArgumentException("СurrentChat must be a valid instance of Chat", nameof(currentChat));

            _currentChat = (Chat)currentChat;
            _messages = _currentChat.Messages;
        }
        #region Methods
        public List<Message> GetMessages() => _messages;

        public async Task SendMessageAsync(Message newMessage)
        {
            ArgumentNullException.ThrowIfNull(newMessage);

            var nextId = _messages.Any() ? _messages.Max(u => u.IdMessage) + 1 : 1;
            newMessage.IdMessage = nextId;
            _messages.Add(newMessage);
            await _appdataService.SaveDataAsync();
        }

        public async Task EditMessageAsync(int idMessage, Message newMessage)
        {
            ArgumentNullException.ThrowIfNull(newMessage);
            Message? messageToEdit = _messages.
                FirstOrDefault(x => x.IdMessage == idMessage)
                ?? throw new InvalidOperationException($"Message with ID {idMessage} not found");

            messageToEdit.Text = newMessage.Text;
            messageToEdit.Image = newMessage.Image;
            messageToEdit.IsChanged = true;
            await _appdataService.SaveDataAsync();
        }

        public async Task DeleteMessageAsync(int idMessage)
        {
            if (_messages.Any(x => x.IdMessage == idMessage))
            {
                _messages.RemoveAll(x => x.IdMessage == idMessage);
                await _appdataService.SaveDataAsync();
            }
            else
                throw new InvalidOperationException($"Message with ID {idMessage} not found");
        }
        public Message? GetMessageById(int idMessage)
        {
            Message? message = _messages.FirstOrDefault(x => x.IdMessage == idMessage);
            return message is null ? throw new InvalidOperationException($"Message with ID {idMessage} not found") : message;
        }
        #endregion
    }
}
