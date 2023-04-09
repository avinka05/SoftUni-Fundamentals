using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(\=|\/)([A-Z][A-Za-z]{2,})\1";
            var places = new List<string>();
            int points = 0;

            MatchCollection matchCollection = Regex.Matches(input,pattern);
            foreach (Match place in matchCollection)
            {
                places.Add(place.ToString().Trim('=', '/'));
            }

            foreach (var item in places)
            {
                points += item.Length;
            }


            Console.WriteLine($"Destinations: {string.Join(", ",places)}");
            Console.WriteLine($"Travel Points: {points}");

        }
    }
}
