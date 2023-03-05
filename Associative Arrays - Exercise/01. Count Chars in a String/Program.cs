using System;
using System.Collections.Generic;
using System.Linq;



namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
           

            Dictionary<char, int> letters = new Dictionary<char, int>();

            foreach (char item in input)
            {
                if (item == ' ')
                {
                    continue;
                }

                if (!letters.ContainsKey(item))
                {
                    letters[item] = 0;
                }

                letters[item]++ ;

            }
            foreach (var item in letters)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
