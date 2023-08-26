using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace InternManagementFinalSoln.Models
{
    public class User
    {
        public static ClaimsIdentity? Username { get; internal set; }
        [Key]
        public int UserId { get; set; }
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordKey { get; set; }

        public string? Role { get; set; }
        public string? Status { get; set; }
    }
}
