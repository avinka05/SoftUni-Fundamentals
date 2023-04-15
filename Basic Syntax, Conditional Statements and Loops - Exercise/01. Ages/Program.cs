using System;
using System.Linq;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string[] array = { "baby", "child", "teenager", "adult", "elder" };
            string word = "";
            int index = 0;
            if (age < 3)
            {

            }
            else if (age < 14)
            {
                index++;
            }
            else if (age < 20)
            {
                index = 2;
            }
            else if (age < 66)
            {
                index = 3;
            }
            else
            {
                index = 4;

            }
            Console.WriteLine($"{array[index]}");
        }
    }
}

