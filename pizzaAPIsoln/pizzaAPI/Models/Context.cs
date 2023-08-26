using Microsoft.EntityFrameworkCore;

namespace pizzaAPI.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions options) : base(options) { 
        }
        public DbSet<Pizza> Pizzas { get; set; }
    }
}
