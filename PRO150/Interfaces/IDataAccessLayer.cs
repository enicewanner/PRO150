using PRO150.Models;
using System.Collections.Generic;

namespace PRO150.Interfaces
{
    public interface IDataAccessLayer
    {
        IEnumerable<Word> GetWords();
        public User GetUser(int? id);
        public User GetUser(string? username);
        void AddUser(User user);
        public bool UserExists(User user);
    }
}
