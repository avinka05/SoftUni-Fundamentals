using System;
using System.Text.RegularExpressions;


namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var pattern = @"\+359(-| )2\1\d{3}\1\d{4}\b";

            var matches = Regex.Matches(input, pattern);



            Console.WriteLine(string.Join(", ", matches));
        }
    }
}
