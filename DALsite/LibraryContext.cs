using Microsoft.EntityFrameworkCore;
using BLsite; 

namespace DALsite
{
    public class LibraryContext : DbContext
    {
        public DbSet<SpellBook>? SpellBooks { get; set; }
        public DbSet<RecipeBook>? RecipeBooks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure your connection string to the database
            optionsBuilder.UseSqlServer("server=(LocalDB)\\MSSQLLocalDB;Initial Catalog=BooksDB;Integrated Security=true");
        }
    

    }

    }

