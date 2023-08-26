using Microsoft.EntityFrameworkCore;

namespace internAndUserApp.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<User>? Users { get; set; }
        public DbSet<Intern>? Interns { get; set; }

    }
}
