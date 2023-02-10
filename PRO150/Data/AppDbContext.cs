using Microsoft.EntityFrameworkCore;
using PRO150.Models;

namespace PRO150.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Word> words { get; set; }
        public DbSet<User> users { get; set; }

    }
}
