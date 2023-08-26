//2)  create an application that will find the greatest of the given numbers.
//Take input until the user enters a negative number


namespace GreatesApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, tempnumber1, tempnumber2, flag;
            number = 0;
            tempnumber2 = 0;
            tempnumber1 = 0;
            flag = 0;
            while(flag == 0)
            {
                Console.WriteLine("Please enter a number:");
                number = Convert.ToInt32(Console.ReadLine());
                if (number >= 0)
                {
                    if (number >= tempnumber1)
                    {
                        tempnumber2 = number;
                        tempnumber1 = number;
                    }
                    else
                    {
                        tempnumber2 = tempnumber1;
                    }
                }
                else

                    flag = 1;
            }
            Console.WriteLine($"Greatest number:{tempnumber2}");
        }
        }

        
        }
