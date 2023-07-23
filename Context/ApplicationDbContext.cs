using challenge_back_end.Models;
using Microsoft.EntityFrameworkCore;

namespace challenge_back_end.Context
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Person> Person => Set<Person>();
        public DbSet<Store> Store => Set<Store>();
    }
}
