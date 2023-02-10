using PRO150.Models;
using System.Collections.Generic;

namespace PRO150.Interfaces
{
    public interface IDataAccessLayer
    {
        IEnumerable<Word> GetWords();
        IEnumerable<User> AddUser(User user);
    }
}
