using pizzaAPI.Interfaces;
using pizzaAPI.Models;

namespace pizzaAPI.Services
{
    public class pizzaRepo:IRepo<string,Pizza>
    {
        private readonly Context _context;

        public pizzaRepo(Context context)
        {
            _context = context;
        }
        public Pizza Add(Pizza item)
        {
            _context.Pizzas.Add(item);
            _context.SaveChanges();
            return item;
        }
            
    }
}
