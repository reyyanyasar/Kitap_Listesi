using _19_10.Models;
using Microsoft.EntityFrameworkCore;

namespace _19_10.Repository
{
    public class RepositoryBaglantisi : DbContext

    {

        public RepositoryBaglantisi(DbContextOptions options) : base(options)
        {


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; Database=kitaplik_db;Trusted_Connection=true");
        }
        public DbSet<Book> Books { get; set; }
    }
}



