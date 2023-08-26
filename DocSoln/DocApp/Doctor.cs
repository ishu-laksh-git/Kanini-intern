//Doctor

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocApp
{
    internal class Doctor
    {
        public int Id  { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }

        public void TakeDoctorDetails()
        {
            Console.WriteLine("Please enter the doctor's Id");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the doctor's Name");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter the doctor's experience in years:");
            Experience = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintDoctorDetails()
        {
            Console.WriteLine("Doctor Details");
            Console.WriteLine($"Doctor Id : {Id}");
            Console.WriteLine($"Doctor name : {Name}");
            Console.WriteLine($"Doctor experience in years : {Experience}");
        }
    }
}

