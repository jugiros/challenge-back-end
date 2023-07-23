using challenge_back_end.Models;
using Microsoft.EntityFrameworkCore;

namespace challenge_back_end.Context
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Person> Person { get; set; }
    }
}
