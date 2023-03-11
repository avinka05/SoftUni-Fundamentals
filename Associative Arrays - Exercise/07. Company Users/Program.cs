using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            var map = new Dictionary<string, List<string>>();

            while ((input=Console.ReadLine())!="End")
            {
                string[] array = input.Split(" -> ");

                string company = array[0];
                string employeeId = array[1];

                if (!map.ContainsKey(company))
                {
                    map[company] = new List<string>();
                }


                if (!map[company].Contains(employeeId))
                {
                    map[company].Add(employeeId);
                }
            }

            foreach (var item in map)
            {
                Console.WriteLine($"{item.Key}");

                foreach (var value in item.Value)
                {
                    Console.WriteLine($"-- {value}");
                }
            }
        }
    }
}
