using System;
using System.Collections.Generic;

namespace _07._Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> name= new List<string>();
            for (int i = 0; i < 3; i++)
            {
                string element = Console.ReadLine();
                name.Add(element);

            }
         
            Console.WriteLine($"{name[0]} {name[2]} {name[1]}");

        }
    }
}
