using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\b(?<day>\d{2})(\.|-|/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            var matches = Regex.Matches(text, pattern);

            foreach (Match item in matches)
            {
                var groups = item.Groups;
                Console.WriteLine($"Day: {groups["day"]}, Month: {groups["month"]}, Year: {groups["year"]}");
            }
        }
    }
}
