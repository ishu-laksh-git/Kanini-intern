namespace internAndUserApp.Models.DTO
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string? Password { get; set; }
        public string? token { get; set; }
        public string? role { get; set; }
    }
}
