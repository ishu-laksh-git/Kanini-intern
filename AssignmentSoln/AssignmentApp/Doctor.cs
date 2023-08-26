using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AssignmentApp
{
    public class Doctor
    {
        // INDEXERS
        public string[,] speciality;
        public string this[int i, int j]
        {
            get { return speciality[i, j]; }
            set { speciality[i, j] = value; }
        }
        public string this[string specials]
        {
            get
            {
                for (int i = 0; i < speciality.Length; i++)
                {
                    if (speciality[i, 0] == specials)
                        return speciality[i, 1];
                }
                return "Speciality not present";
            }
        }
        public Doctor(int id, string name, int experience, int specialityCount)
        {
            this.name = name;
            Id = id;
            Experience = experience;
            this.specialityCount = specialityCount;
        }
        public Doctor(int id, string dname, int exp)
        {
            Id = id; ;
            name = dname;
            Experience = exp;
        }
        public Doctor(int splCount)
        {
            speciality = new string[splCount, 2];
        }
        public Doctor()
        {
            speciality = new string[specialityCount, 2];
        }
        public string name { get; set; }
        public int Id { get; set; }
        public int Experience { get; set; } = 0;
        public int specialityCount { get; set; } = 5;
        private void TakeDetails()
        {
            Console.WriteLine("Please enter the Doc Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Please enter the Total experience of the doctor:");
           
            Experience = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many things does your doc spealize in ??");
            specialityCount = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the specialities of your doctor:");
 for (int i = 0; i < specialityCount; i++)
            {
                Console.WriteLine("Please enter the speciality of your doctor:");
                speciality[i, 0] = Console.ReadLine();
                for (int j = 0; j < specialityCount; j++)
                {
                    Console.WriteLine($"Please enter the number of years of specialization in { speciality[i, 0]}");
                speciality[i, 1] = Console.ReadLine();
                }
            }
        }
        public void TakeDocDetails()
        {
            Console.WriteLine("Please enter the Doc Id");
            Id = Convert.ToInt32(Console.ReadLine());
            TakeDetails();
        }
        public void TakeDocDetails(int id)
        {
            Id = id;
            TakeDetails();
        }
        public void PrintDocDetails()
        {
            Console.WriteLine("Doc Details");
            Console.WriteLine($"Doc Id : {Id}");//Interpollation
            Console.WriteLine($"Doc name : {name}");//Interpollation
            int count = 0;
            while (speciality[count, 0] != null)
            {
                Console.WriteLine($" {count + 1} - specialization of your doc is{ speciality[count, 0]} for { speciality[count, 1]} years");
            count++;
            }
            Console.WriteLine();
        }
        public void PrintSpl()
        {
            int count = 0;
            while (speciality[count, 0] != null)
            {
                Console.WriteLine($" {count + 1} - specialization of your doc is {speciality[count, 0]}  for { speciality[count, 1]} years");
            count++;
            }
            Console.WriteLine();
        }
        //Operators
        public static Boolean operator >(Doctor left, Doctor right)
        {
            if (left.specialityCount > right.specialityCount && left.Experience >
           right.Experience)
                return true;
            return false;
        }
        public static Boolean operator <(Doctor left, Doctor right)
        {
            if (left.specialityCount < right.specialityCount && left.Experience <
           right.Experience)
                return true;
            return false;
        }
    }
}
          
