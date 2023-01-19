using System;
using System.Collections.Generic;

namespace _5._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                string element = Console.ReadLine();
                elements.Add(element);

            }
            elements.Reverse();
            Console.WriteLine(string.Join(" ",elements));
            
        }
    }
}
