//4) Find the length of the given user's name


namespace StringLengthApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a name:");
            string UName = Console.ReadLine();
            int length = UName.Length;
            Console.WriteLine($"Length of {UName} is {length}");
            Console.ReadKey();
        }
    }
}