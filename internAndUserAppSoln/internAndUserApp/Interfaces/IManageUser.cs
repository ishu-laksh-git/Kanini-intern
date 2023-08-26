using internAndUserApp.Models.DTO;

namespace internAndUserApp.Interfaces
{
    public interface IManageUser
    {
        public Task<UserDTO> Login(UserDTO user);
        public Task<UserDTO> Register(InternDTO intern);

    }
}
