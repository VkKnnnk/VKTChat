using VKTChat.Core.Models;

namespace VKTChat.Core.Services
{
    public class UserService : IUserService
    {
        #region Properties
        private List<User> _users = new List<User>();
        #endregion
        #region Constants
        private readonly IAppdataService _appdataService;
        #endregion
        public UserService(IAppdataService appdataService)
        {
            _appdataService = appdataService;
            _ = LoadUsersAsync();
        }
        #region Methods
        private async Task LoadUsersAsync()
        {
            _users = await _appdataService.GetDataAsync();
        }
        public List<User> GetUsers() => _users;
        public async Task AddUserAsync(User newUser)
        {
            if (!_users.Any(x => x.UserName == newUser.UserName))
            {
                var nextId = _users.Any() ? _users.Max(u => u.IdUser) + 1 : 1;
                newUser.IdUser = nextId;
                _users.Add(newUser);
                await _appdataService.SaveDataAsync();
            }
        }
        public async Task EditUserAsync(int idUser, User newData)
        {
            User? userToEdit = _users.FirstOrDefault(x => x.IdUser == idUser);
            if (userToEdit is null)
                throw new InvalidOperationException($"User with ID {idUser} not found");

            userToEdit.UserName = newData.UserName;
            userToEdit.DisplayName = newData.DisplayName;
            userToEdit.AboutMe = newData.AboutMe;
            userToEdit.UserPhoto = newData.UserPhoto;

            await _appdataService.SaveDataAsync();
        }
        public async Task DeleteUserAsync(int idUser)
        {
            if (_users.Any(u => u.IdUser == idUser))
            {
                _users.RemoveAll(u => u.IdUser == idUser);
                await _appdataService.SaveDataAsync();
            }
            else
                throw new InvalidOperationException($"User with ID {idUser} not found");
        }
        public User? GetUserById(int idUser)
        {
            User? user = _users.FirstOrDefault(x => x.IdUser == idUser);
            if (user is null)
                throw new InvalidOperationException($"User with ID {idUser} not found");
            return user;
        }
        #endregion
    }
}
