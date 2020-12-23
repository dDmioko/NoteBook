using System;
using System.Collections.Generic;
using System.Linq;
using NoteBook.Data;
using NoteBook.Data.Models;

namespace NoteBook.Services
{
    public class UserService : IUserSercive
    {
        private readonly NoteBookDbContext _context;

        public UserService(NoteBookDbContext context)
        {
            _context = context;
        }

        public void AddUser(UserService user)
        {
            _context.Add(user);
            _context.SaveChanges();
        }

        public void DeleteUser(int userId)
        {
            var userToDelete = _context.Users.Find(userId);
            if (userToDelete != null)
            {
                _context.Remove(userToDelete);
            }
            else
            {
                throw new InvalidOperationException("Can't delete user that doesn't exist");
            }
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User GetUser(int userId)
        {
            return _context.Users.Find(userId);
        }
    }
}
