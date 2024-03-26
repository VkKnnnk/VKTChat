using VKTChat.Core.Models;

namespace VKTChat.Core.Services
{
    public class UserDataContext : IDataContext
    {
        private User? _currentUser;
        public object? GetCurrentData()
        {
            return _currentUser;
        }

        public void SetContext(object currentData)
        {
            if (currentData is null)
                throw new ArgumentNullException(nameof(currentData));
            _currentUser = currentData as User;
        }
    }
}
