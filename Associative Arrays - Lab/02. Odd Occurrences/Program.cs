using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ");

            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach (var word in words)
            {
                string currentWord = word.ToLower();
                if (!counts.ContainsKey(currentWord))
                {
                    counts.Add(currentWord, 0);

                }
                counts[currentWord]++;
                
            }
            foreach (var item in counts)
            {
                if (item.Value%2 != 0)
                {
                    Console.Write(item.Key + " ");
                }
            }

        }
    }
}
