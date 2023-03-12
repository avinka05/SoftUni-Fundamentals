using System;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordsToRemove = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var word in wordsToRemove)
            {                
                    string substitution = new string('*', word.Length);
                    text = text.Replace(word, substitution);               
            }
            Console.WriteLine(text);
        }
    }
}
