using Microsoft.EntityFrameworkCore;

namespace InternManagementFinalSoln.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User>? Users { get; set; }
        public DbSet<Intern>? Interns { get; set; }
        public DbSet<InternLog>? InternLogs { get; set; }
        public DbSet<InternTicket>? InternTickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Intern>().Property(i => i.InternId).ValueGeneratedNever();
        }
    }
}
