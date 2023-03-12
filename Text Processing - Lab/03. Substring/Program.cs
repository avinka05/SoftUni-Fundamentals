using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();
            string words = Console.ReadLine();

            while (words.Contains(wordToRemove))
            {
                words = words.Replace(wordToRemove, "");
            }

            Console.WriteLine(words);
        }
    }
}
