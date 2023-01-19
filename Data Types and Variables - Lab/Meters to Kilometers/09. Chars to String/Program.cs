using System;
using System.Collections.Generic;

namespace _09._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char element = char.Parse(Console.ReadLine());
            if (element >= 65 && element <= 90)
            {
               Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
