using System;

namespace _4Centuries_to_Minute
{
    class Program
    {
        static void Main(string[] args)
        {
            int centures = int.Parse(Console.ReadLine());
            var years = centures * 100m;
            decimal days = Math.Floor(years * 365.2422m);
            decimal hours = days * 24m;
            decimal minutes = hours * 60;
            Console.WriteLine($"{centures} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
