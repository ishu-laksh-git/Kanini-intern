using InternUserManagement.Interfaces;

namespace InternUserManagement.Models
{
    public class GeneratePassord : IGeneratePassword
    {
        public async Task<string?> GeneratePassword(Intern intern)
        {
            string password = String.Empty;
            password = intern.Name.Substring(0, 4);
            password += intern.DateOfBirth.Date;
            password += intern.DateOfBirth.Month;

            return password;
        }
    }
}
