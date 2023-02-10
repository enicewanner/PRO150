using PRO150.Interfaces;
using PRO150.Models;

namespace PRO150.Data
{
    public class CodenamesDAL : IDataAccessLayer
    {
        private AppDbContext db;

        public CodenamesDAL(AppDbContext indb)
        {
            db = indb;
        }

        public IEnumerable<User> AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Word> GetWords()
        {
            throw new NotImplementedException();
        }
    }
}
