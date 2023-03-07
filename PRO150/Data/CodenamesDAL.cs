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

        public void AddUser(User user)
        {
            db.users.Add(user);
            db.SaveChanges();
        }

        public User GetUser(int? id)
        {
            return db.users.Where(u => u.Id == id).FirstOrDefault();
        }

        public User GetUser(string? username)
        {
            return db.users.Where(u => u.Username == username).FirstOrDefault();
        }

        public IEnumerable<User> GetUser()
        {
            throw new NotImplementedException();
        }

        public User GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public Word GetWord(int id)
        {
            return db.words.Where(m => m.Id == id).FirstOrDefault();
        }

        public IEnumerable<Word> GetWords()
        {
            throw new NotImplementedException();
        }

        public bool UserExists(User user)
        {
            if (GetUser(user.Username) != null)
            {
                return true;
            }
            else return false;
        }
    }
}
