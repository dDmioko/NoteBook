using System.Collections.Generic;
using NoteBook.Data.Models;

namespace NoteBook.Services
{
    public interface IUserSercive
    {
        public IEnumerable<User> GetAllUsers();
        public User GetUser(int userId);
        public void AddUser(UserService user);
        public void DeleteUser(int userId);
    }
}