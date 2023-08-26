namespace UnderstandingPartialApp
{
    internal partial class Program
    {
        int i=9;
        void hello()
        {
            Console.WriteLine("hi");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            new Program().check();
        }
    }
}