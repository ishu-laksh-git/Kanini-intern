﻿namespace InternManagementFinalSoln.Models.DTO
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string? Password { get; set; }
        public string? Token { get; set; }
        public string? Role { get; set; }
    }
}
