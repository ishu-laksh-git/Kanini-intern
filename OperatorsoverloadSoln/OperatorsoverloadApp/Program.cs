using DoctorClassLibrary;
using System.Xml.Linq;

namespace OperatorsoverloadApp
{
    internal class Program
    {
        void UnderstandingIndexerOverloading()
        {
            Doctor D1 = new Doctor();
            D1.TakeDoctorDetails();
            Console.WriteLine("Enter the speciality:");
            string? splty = Console.ReadLine();
            int exp = D1[splty];
            if (exp > 0) 
            {
                Console.WriteLine($"Experience in {splty}:{exp}");
            }
            else
            {
                Console.WriteLine($"Speciality {splty} not found");
            }
        }
        void UnderstandingOperatorOverloading()
        {
            int status;
            Doctor D1 = new Doctor();
            Doctor D2 = new Doctor();
            D1.TakeDoctorDetails();
            D2.TakeDoctorDetails();
            status = (D1 == D2);
            switch(status)
            {
                case 1: Console.WriteLine("Both are equally specialized and experienced");break;
                case 2: Console.WriteLine($"{D1.Name} is more specialized and experienced");break;
                case 3: Console.WriteLine($"{D2.Name} is more specialized and experienced");break;
                case 4: Console.WriteLine($"{D1.Name} is more experienced and {D2.Name} is more specialized");break;
                case 5: Console.WriteLine($"{D1.Name} is more specialized and {D2.Name} is more experienced");break;
                case 6: Console.WriteLine($"They are equally experienced and {D1.Name} is more specialized");break;
                case 7: Console.WriteLine($"{D1.Name} is more experienced and they are equally specialized");break;
                case 8: Console.WriteLine($"They are equally experienced and {D2.Name} is more specialized");break;
                case 9: Console.WriteLine($"{D2.Name} is more experienced and they are equally specialized");break;
            }
        }
        //void UnderstandingIndexerOverloading()
        //{
        //    Pizza p1, p2, p3;
        //    p1 = new Pizza(345, "ABC", 101, 3);
        //    p1[0] = "Onion";
        //    p1[1] = "Capsicum";
        //    p1[2] = "Olives";
        //    int idx = p1["Olives"];
        //    if (idx < 0)
        //        Console.WriteLine("No such topping is present. Dont dream");
        //    else
        //    {
        //        Console.WriteLine("The index of the topping Olives is " + idx);
        //        p1[idx] = "Changed";
        //        Console.WriteLine($"The topping in the {idx} is {p1[idx]}");
        //    }

        //}
        static void Main(string[] args)
        {
            //new Program().UnderstandingIndexerOverloading();
            //new Program().UnderstandingOperatorOverloading();

            ////declaring an array
            //int[] a = new int[5];
            //char[] b = new char[5];

            ////declaring and initializing an array
            //int[] c = new int[] { 1, 2, 3, 4, 5 };
            //char[] d = new char[5] { 'a', 'b', 'c', 'd', 'e' };

            ////getting array size from user
            //int arrSize;
            //int[] UserArray;
            //Console.WriteLine("Enter the array size:");
            //arrSize = Convert.ToInt32(Console.ReadLine());
            //UserArray = new int[arrSize];

            ////Getting the elements of an array
            //for(int i = 0; i < arrSize; i++)
            //{
            //    Console.WriteLine("Enter an array element:");
            //    UserArray[i] = Convert.ToInt32(Console.ReadLine());
            //}

            ////Printing the elements of an array
            //for (int i = 0; i < arrSize; i++)
            //{
            //    Console.WriteLine(UserArray[i]);
            //}
            string name = "Something that i would like to play with";
            char[] seperate = name.ToCharArray();
            seperate[4] = 'z';
            name = new string(seperate);
            Console.WriteLine(name);
            string[] words = name.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }



        }
    }
}