namespace InternManagementFinalSoln.Models.DTO
{
    public class PasswordDTO:User
    {
        public string? OldPassword { get; set; }
        public string? NewPassword { get; set; }
    }
}
