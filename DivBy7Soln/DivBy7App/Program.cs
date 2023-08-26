//3) Find the avearage of all the numbers that are divisible by 7.
//Take input until the user enters a negative number

namespace DivBy7App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number,flag,count;
            double tempnumber1;
            number = 0;
            tempnumber1 = 0;
            count = 0;  
            flag = 0;
            while (flag == 0)
            {
                Console.WriteLine("Please enter a number:");
                number = Convert.ToInt32(Console.ReadLine());
                if (number >= 0)
                {
                    if (number %7 == 0)
                    {
                        tempnumber1 = (number + tempnumber1);
                        count++;
                    }
                    else
                    {
                        continue;
                    }
                }
                else

                    flag = 1;
            }
            Console.WriteLine($"Average:{tempnumber1/count}");

        }
    }
}