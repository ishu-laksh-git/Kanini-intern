using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestApp
{
    internal class Program
    {
        static double num1, num2, num3;
        static void TakeThreeNumbers()
        {
            Console.WriteLine("Please enter the first number:");
            num1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the third number");
            num3 = Convert.ToDouble(Console.ReadLine());
        }

        static void FindGreatest()
        {
            if ((num1 > num2) && (num1 > num3))
            {
                Console.WriteLine("Greatest number is " + num1);
            }
            else
            {
                if(num2 > num3) {
                    Console.WriteLine("Greatest number is " + num2);
                }
                else { Console.WriteLine("Greatest number is " + num3); }
            }
        }
        static void Main(string[] args)
        {
            TakeThreeNumbers(); 
            FindGreatest();
            Console.ReadKey();
        }
    }
}
