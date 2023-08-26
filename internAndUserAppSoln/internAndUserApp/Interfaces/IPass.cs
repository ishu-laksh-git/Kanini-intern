using internAndUserApp.Models;

namespace internAndUserApp.Interfaces
{
    public interface IPass
    {
        public Task<string?> GeneratePassword(Intern intern);
    }
}
