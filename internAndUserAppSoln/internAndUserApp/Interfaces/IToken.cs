using internAndUserApp.Models.DTO;

namespace internAndUserApp.Interfaces
{
    public interface IToken
    {
        public string GenerateToken(UserDTO user);
    }
}
