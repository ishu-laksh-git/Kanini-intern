//1) Create an application that take 2 numbers and finds its sum, product and divide the first by second,
//also subtract the second from the first. 
//Include another method to find the remainder when the first number is divided by second


namespace CalciApp
{
    internal class Program
    {
        static void remainder(double number1, double number2)
        {
            Console.WriteLine($"{number1} % {number2} = {number1%number2}");
        }
        static void Main(string[] args)
        {
            double number1, number2;
            Console.WriteLine("Please enter the first number:");
            number1 = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Please enter the second number:");
            number2 = Convert.ToDouble(Console.ReadLine());

            //add
            Console.WriteLine("Sum:");
            Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
            Console.WriteLine("Product:");
            Console.WriteLine($"{number1} x {number2} = {number1 * number2}");
            Console.WriteLine("Quotient:");
            Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
            Console.WriteLine("Difference:");
            Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
            Console.WriteLine("Remainder");
            remainder(number1,number2);
            Console.ReadKey();
        }
    }
}