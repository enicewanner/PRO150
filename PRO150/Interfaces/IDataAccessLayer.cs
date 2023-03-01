using PRO150.Models;
using System.Collections.Generic;

namespace PRO150.Interfaces
{
    public interface IDataAccessLayer
    {
        IEnumerable<Word> GetWords();
        Word GetWord(int id);
        IEnumerable<User> AddUser(User user);
        User GetUser(int id);
    }
}
