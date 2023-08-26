﻿using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace bigbang3.Models
{
    public class Context:DbContext
    {
        static string pass = "admin";
        static HMACSHA512 hmac = new HMACSHA512();
        Byte[] PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(pass));
        Byte[] PasswordKey = hmac.Key;

        public Context(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Traveller> Travellers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    Email = "admin@gmail.com",
                    PasswordHash = PasswordHash,
                    PasswordKey = PasswordKey,
                    Role = "Admin"
                });
        }
    }
}
