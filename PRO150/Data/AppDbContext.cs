using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using PRO150.Models;

namespace PRO150.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ): base(options)
        {

        }

        public DbSet<Word> words { get; set; }
        public DbSet<User> users { get; set; }

    }
}
