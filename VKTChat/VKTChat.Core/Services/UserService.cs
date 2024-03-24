using System;
using VKTChat.Core.Models;

namespace VKTChat.Core.Services
{
    public class UserService : IUserService
    {
        public bool DeleteUser(int idUser)
        {
            throw new NotImplementedException();
        }

        public bool EditUser(int idUser, User newData)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public User? LoginUser(string username, string password)
        {
            throw new NotImplementedException();
        }

        public User RegistrateUser(User newData)
        {
            throw new NotImplementedException();
        }
    }
}
