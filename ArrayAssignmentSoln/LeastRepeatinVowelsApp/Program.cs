//Take a string from user the words seperated by comma(",").
//Seperate the words and find the words with the least number of repeating vowels.
//print the count and the word. If there is a tie then print all the words that tie for the least

using System;

namespace LeastRepeatinVowelsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words;
            int[][] vowelCount = new int[5][];
            List<char> s = new List<char>();
            List<string> leastrepeated = new List<string>();
            int repeatvowel = 0;
            int count = 0;
            int leastrepeatedvalue = 100;
            Console.WriteLine("Hello, please enter the words separated by commas:");
            string input = Console.ReadLine();
            words = input.Split(",");
            Console.WriteLine("\nThe words you have entered are:");
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
            for (int i = 0; i < words.Length; i++)
            {
                char[] chars = words[i].ToCharArray();
                for (int j = 0; j < chars.Length; j++)
                {
                    if (chars[j] == 'a' || chars[j] == 'e' || chars[j] == 'i' || chars[j] == 'o' || chars[j] == 'u')
                    {
                        if (s.Contains(chars[j]))
                        {
                            repeatvowel++;
                        }
                        else
                        {
                            s.Add(chars[j]);
                        }
                        count++;
                    }
                }

                if (repeatvowel < leastrepeatedvalue)
                {
                    leastrepeatedvalue = repeatvowel;

                    leastrepeated.Add(words[i]);
                }
                Console.WriteLine();
                Console.WriteLine($"for the word : {words[i]}");
                Console.WriteLine(" the number of vowels in this word :" + count);
                Console.WriteLine(" the number of repeated vowels in this word :" + repeatvowel);
                repeatvowel = 0;
                count = 0;
                s.Clear();
            }
            Console.WriteLine("the word with the least repeated number of vowels is : ");
            for (int i = 0; i < leastrepeated.Count; i++)
            {
                Console.WriteLine(leastrepeated[i]);
            }
        }
    }
}