//2) Take a string from user the words seperated by comma(",").
//Seperate the words and find out the longest and the shortest word in it


namespace ArrayAssignmentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words;
            string long1 = "", long2 = "", short1 = "", short2 = "";
            Console.WriteLine("Hello, please enter the words separated by commas:");
            string input = Console.ReadLine();
            words = input.Split(",");
            Console.WriteLine("\nThe words you have entered are:");
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
                //longest
                if (words[i].Length >= long1.Length)
                {
                    long2 = words[i];
                    long1 = words[i];
                }
                else
                {
                    long2 = long1;
                }
            } 
            //shortest
            short2 = long2;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length <= short2.Length)
                {
                    short2 = words[i];
                    short1 = words[i];
                }
                else
                {
                    short2 = short1;
                }
            }
                Console.WriteLine($"The longest term:{long2}");
            Console.WriteLine($"The shortest term:{short1}");
        }
    }
}