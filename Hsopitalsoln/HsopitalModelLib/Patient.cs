using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HsopitalModelLib
{
    public class Patient
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phno { get; set; }
        public int age { get; set; }

        public void TakePatientDetails()
        {
            Console.WriteLine("Enter the name of the patient ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the phone number of the patient ");
            phno = Console.ReadLine();
            while (!(phno.Length == 10))
            {
                Console.WriteLine("Enter a valid ten digith phone number");
                phno = Console.ReadLine();
            }
            int Age;
            Console.WriteLine("Enter the age of the patient");
            while (!Int32.TryParse(Console.ReadLine(), out Age))
            {
                Console.WriteLine("Enter the valid age ");
            }
            age = Age;
        }
        public override string ToString()
        {
            string message = "";
            message += "\nPatient Id : " + id;
            message += "\nPatient Name : " + name;
            message += "\nPatient phone number : " + phno;
            message += "\nPatient Age : " + age;
            return message;
        }
    }

}
