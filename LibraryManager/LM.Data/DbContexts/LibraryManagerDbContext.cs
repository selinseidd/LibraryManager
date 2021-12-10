using LM.Data.Entites;
using Microsoft.EntityFrameworkCore;

namespace LM.Data.DbContexts
{
    public class LibraryManagerDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Library> Library { get; set; }

        public LibraryManagerDbContext(DbContextOptions<LibraryManagerDbContext> options) : base(options)
        { }
    }
}
