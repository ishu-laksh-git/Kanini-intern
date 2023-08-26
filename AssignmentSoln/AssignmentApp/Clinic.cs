//3] Add functionality to the clinic class to add or remove specialization of a doctor. Add or 
//remove a doctor

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AssignmentApp
{
    public class Clinic
        {
            Doctor[] doctor;
            private int CountDoc;
            private int PointerPosition;
            public Doctor this[int j]
            {
                get { return doctor[j]; }
                set { doctor[j] = value; }
            }
            public Clinic()
            {
                Console.WriteLine("welcome to HelloWorld Hospitals!!");
                Console.WriteLine();
                Console.WriteLine("Enter the number of doc-details you want to enter.");
               
                Console.WriteLine();
                CountDoc = Convert.ToInt32(Console.ReadLine());
                doctor = new Doctor[10];
                PointerPosition = CountDoc;

            }
    public void takedoc()
    {
        for (int i = 0; i < CountDoc; i++)
        {
            doctor[i] = new Doctor();
            doctor[i].TakeDocDetails(100 + i + 1);
            Console.WriteLine();
        }
    }
    public void printdoc()
    {
        for (int i = 0; i < doctor.Length; i++)
        {
            if (doctor[i] != null)
            {
                doctor[i].PrintDocDetails();
                Console.WriteLine();
            }
            else
                break;
        }
    }
    public void AddDoc()
    {
        //int position = -1;
        //for (int i = 0; i < doctor.Length; i++)
        //{
        // if (doctor[i] == null)
        // position = i;
        //}
        doctor[PointerPosition] = new Doctor();
        doctor[PointerPosition].TakeDocDetails();
        Console.WriteLine("After Adding Doctor");
        PointerPosition++;
        //printdoc();
    }
    public void RemoveDoc(string docName)
    {
        int position = -1;
        for (int i = 0; i < CountDoc; i++)
        {
            if (doctor[i].name == docName)
                position = i + 1;
        }
        for (int i = position - 1; i < doctor.Length - 1; i++)
        {
            doctor[i] = doctor[i + 1];
        }
        for (int i = 0; i < CountDoc - 1; i++)
        {
            doctor[i].PrintDocDetails();
            Console.WriteLine();
        }
    }
    public void AddSpeciality()
    {
        //int freePosition = -1;
        int position = -1;
        Console.WriteLine("Enter the doctors name for whom you wanna Add their speciality");
       
        string dname = Console.ReadLine();
        for (int j = 0; j < CountDoc; j++)
        {
            if (doctor[j].name == dname)
            {
                //doctor[i].PrintSpl();
                position = j;
                break;
            }
        }
        Console.WriteLine("Which speciality of the doctor you wanna Add? ");
        string ToBeAddedSpl = Console.ReadLine();
        Console.WriteLine($"Number of years specialized in {ToBeAddedSpl}? ");
       
        string ToBeAddedExp = Console.ReadLine();
        int i = 0;
        while (doctor[position].speciality[i, 0] != null)
        {
            if (doctor[position].speciality[i, 0] == "")
            {
                doctor[position].speciality[i, 0] = ToBeAddedSpl;
                doctor[position].speciality[i, 1] = ToBeAddedExp;
            }

            i++;
        }
        Console.WriteLine("After addition");
        doctor[position].PrintSpl();
    }
    public void RemoveSpeciality()
    {
        int position = -1;
        Console.WriteLine("Enter the doctors name for whom you wanna remove their speciality");
       
        string dname = Console.ReadLine();
        for (int j = 0; j < CountDoc; j++)
        {
            if (doctor[j].name == dname)
            {
                doctor[j].PrintSpl();
                position = j;
                break;
            }
        }
        Console.WriteLine("Which speciality of the doctor you wanna remove?");
        
         string ToBeRemoved = Console.ReadLine();
        int i = 0;
        while (doctor[position].speciality[i, 0] != null)
        {
            if (doctor[position].speciality[i, 0] == ToBeRemoved)
            {
                doctor[position].speciality[i, 0] = "";
                doctor[position].speciality[i, 1] = "";
            }
            i++;
        }
        Console.WriteLine("After Removal");
        doctor[position].PrintSpl();

    }
}
}