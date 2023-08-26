﻿using System.ComponentModel.DataAnnotations;

namespace bigbang3.Models
{
    public class Agent
    {
        public Agent()
        {
            Name = string.Empty;
            Gender = "Unknown";
        }
        [Key]
        public int TravelId { get; set; }
        public string? Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string? Phone { get; set; }
        public int? AgencyID { get; set; }
        public string? AgencyName { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? IsApproved { get; set; }
        public string? GSTnumber { get; set; }
        public User? Users { get; set; }
    }
}
