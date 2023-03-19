using System;
using System.Text.RegularExpressions;


namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var name = (@"\b[A-Z][a-z]+ [A-Z][a-z]+");
            var matches = Regex.Matches(input,name);

            Console.WriteLine(string.Join(" ",matches));
        }
    }
}
