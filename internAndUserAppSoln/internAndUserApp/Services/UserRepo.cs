using internAndUserApp.Interfaces;
using internAndUserApp.Models;

namespace internAndUserApp.Services
{
    public interface UserRepo:IRepo<int,User>
    {
        private readonly Context _context;
        private readonly ILogger<UserRepo> _logger;

        public UserRepo(UserContext context, ILogger)
    }
}
