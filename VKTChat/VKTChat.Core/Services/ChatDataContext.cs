using VKTChat.Core.Models;

namespace VKTChat.Core.Services
{
    public class ChatDataContext : IDataContext
    {
        private Chat? _currentChat;
        public object? GetCurrentData()
        {
            return _currentChat;
        }

        public void SetContext(object currentData)
        {
            if (currentData is null)
                throw new ArgumentNullException(nameof(currentData));
            _currentChat = currentData as Chat;
        }
    }
}
