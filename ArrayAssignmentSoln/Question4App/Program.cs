//4) Take number from user until 0 is entered. Print all the prime numbers entered

namespace Question4App
{
    internal class Program
    {
        static bool PrimeNo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            int[] nums = new int[100];
            int count = 0;

            Console.WriteLine("Enter the numbers ");
            int num = int.Parse(Console.ReadLine());

            while (num != 0)
            {
                nums[count] = num;
                count++;
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Prime numbers are");
            for (int i = 0; i < count; i++)
            {
                if (PrimeNo(nums[i]))
                {
                    Console.Write(nums[i] + " ");
                }
            }
        }
    }
}
