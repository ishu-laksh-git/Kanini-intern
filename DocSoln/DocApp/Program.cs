//6) Create a class Doctor(Id, Name, Experience), Has behaviour to take
//the doctor details from user and another to print the doctor's details.
//Create a class Clinic
//properties - 
//IncludeDoctor- ceate a new doctor and returns it
//PrintDoctorDetails - takes the doctor as parameter and prints the details

namespace DocApp
{
    internal class Program
    {
        Clinic clinic;
        public Program()
        {
            clinic = new Clinic();
        }
        public void ManageClinic()
        {
            clinic.IncludeDoctor();
            clinic.PrintDocDetails();
        }
        static void Main(string[] args)
        {
            new Program().ManageClinic();
        }
    }
}