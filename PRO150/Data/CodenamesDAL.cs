using PRO150.Interfaces;
using PRO150.Models;

namespace PRO150.Data
{
    public class CodenamesDAL : IDataAccessLayer
    {
        private static List<Card> cards = new List<Card>()
        {
            new Card(1, Card.colors[Card.rand.Next(4)]),
            new Card(2, Card.colors[Card.rand.Next(4)]),
            new Card(3, Card.colors[Card.rand.Next(4)]),
            new Card(5, Card.colors[Card.rand.Next(4)]),
            new Card(6, Card.colors[Card.rand.Next(4)]),
            new Card(7, Card.colors[Card.rand.Next(4)]),
            new Card(8, Card.colors[Card.rand.Next(4)]),
            new Card(9, Card.colors[Card.rand.Next(4)]),
            new Card(10, Card.colors[Card.rand.Next(4)]),
            new Card(11, Card.colors[Card.rand.Next(4)]),
            new Card(12, Card.colors[Card.rand.Next(4)]),
            new Card(13, Card.colors[Card.rand.Next(4)]),
            new Card(14, Card.colors[Card.rand.Next(4)]),
            new Card(15, Card.colors[Card.rand.Next(4)]),
            new Card(16, Card.colors[Card.rand.Next(4)]),
            new Card(17, Card.colors[Card.rand.Next(4)]),
            new Card(18, Card.colors[Card.rand.Next(4)]),
            new Card(19, Card.colors[Card.rand.Next(4)]),
            new Card(20, Card.colors[Card.rand.Next(4)]),
            new Card(21, Card.colors[Card.rand.Next(4)]),
            new Card(22, Card.colors[Card.rand.Next(4)]),
            new Card(23, Card.colors[Card.rand.Next(4)]),
            new Card(24, Card.colors[Card.rand.Next(4)]),
            new Card(25, Card.colors[Card.rand.Next(4)]),
        };

        private AppDbContext db;

        public CodenamesDAL(AppDbContext indb)
        {
            db = indb;
        }

        public IEnumerable<User> AddUser(User user)
        {
            throw new NotImplementedException();
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
    }
}
