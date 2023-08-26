//1) * Update the doctor class to have an array of speciality that
//the doctor can handle(array). Update the addDoctor and the print
//doctor accordingly

//*Update the clinic class to take the number of speciality
//and initialize the doctor class accordingly.

// *Ensure you expose the doctor array through
// the clinic object through the clinic object

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocApp
{
    internal class Doctor
    {
        public string[] speciality = new string[5];
        public string this[int index]
        {
            get { return speciality[index]; }
            set { speciality[index] = value;}
        }

        //public Doctor(int spltyCount)
        //{
        //    speciality = new string[spltyCount];
        //}

        public Doctor()
        {
            speciality = new string[5];
        }

        public Doctor(int specialityCount)
        {
            speciality = new string[specialityCount];
        }

        public Doctor(int id, string? name, int experience):this()
        {
            Id = id;
            Name = name;
            Experience = experience;
        }
        
        public Doctor(int id, string? name, int experience, int spltyCount) : this(id,name, experience)
        {
            speciality = new string[spltyCount];
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }


        public void TakeDetails()
        {
            //Console.WriteLine("Please enter the doctor's Id");
            //Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the doctor's Name");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter the doctor's experience in years:");
            Experience = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many specialities do they have?");
            int splty = Convert.ToInt32(Console.ReadLine());    
            for( int i = 0;i<splty;i++)
            {
                Console.WriteLine($"Please enter speaciality{i+1} :");
                speciality[i] = Console.ReadLine();
            }
            Console.WriteLine("-----------------------------------------------------------");
        }
        public void PrintDoctorDetails()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Doctor Details");
            Console.WriteLine($"Doctor Id : {Id}");
            Console.WriteLine($"Doctor name : {Name}");
            Console.WriteLine($"Doctor experience in years : {Experience}");
            int count = 0;
            while (speciality[count] != null)
            {
                Console.WriteLine($"Speciality{count+1} : {speciality[count]}");
                count++;
            }
            Console.WriteLine("-----------------------------------------------------------");
        }
        public void TakeDoctorDetails()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Please enter the Doctor's Id");
            Id = Convert.ToInt32(Console.ReadLine());
            TakeDetails();
        }

        public void TakeDoctorDetails(int id)
        {
            Id = id;
            TakeDetails();
        }
    }
}
