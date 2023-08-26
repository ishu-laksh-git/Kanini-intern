//Clinic

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocApp
{
    internal class Clinic
    {
        Doctor[] doctors;

        public Clinic()
        {
            Console.WriteLine("Welcome to our clinic!");
            Console.WriteLine("How many doctors are available?");
            int count = Convert.ToInt32(Console.ReadLine());    
            doctors = new Doctor[count];
        }
        public void PrintDocDetails()
        {
            for(int i = 0;i< doctors.Length; i++)
            {
                doctors[i].PrintDoctorDetails();
            }
        }
        public void IncludeDoctor()
        {
            for(int i = 0;i<doctors.Length;i++)
            {
                doctors[i] = new Doctor();
                doctors[i].TakeDoctorDetails();
            }
        }
    }
}
