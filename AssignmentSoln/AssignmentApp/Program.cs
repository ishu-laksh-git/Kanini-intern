using System.Numerics;

namespace AssignmentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clinic pm = new Clinic();
            pm.takedoc();
            pm.printdoc();
            Console.WriteLine("Do u wanna Add or Remove doctors?");
            string decision = Console.ReadLine();
            if (decision.ToLower() == "remove")
            {
                Console.WriteLine("Enter the doctor u wanna remove: ");
                string docName = Console.ReadLine();
                pm.RemoveDoc(docName);
            }
            else if (decision.ToLower() == "add")
            {
                pm.AddDoc();
                pm.printdoc();
            }
            Console.WriteLine("Do u wanna Remove or update any speciality of a doctor ? ");
 if (Console.ReadLine() == "yes")
            {
                pm.RemoveSpeciality();
                Console.WriteLine("Do u wanna Add any speciality of a doctor?");
                if (Console.ReadLine() == "yes")
                {
                    pm.AddSpeciality();
                }
                else
                    Console.WriteLine("Thank You");
            }
            else
                Console.WriteLine("Thank You");
        }
    }
}
       