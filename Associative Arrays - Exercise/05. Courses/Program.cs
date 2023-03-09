using System;
using System.Collections.Generic;
using System.Linq;


namespace _05._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var map = new Dictionary<string, List<string>>();
            string input = string.Empty;
            while ((input=Console.ReadLine())!="end")
            {

                string[] words = input.Split(" : ");
                string courseName = words[0];
                string registeredStudents = words[1];

                if (!map.ContainsKey(courseName))
                {
                    map[courseName] = new List<string>();
                }
                map[courseName].Add(registeredStudents);

            }

            foreach (var item in map)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count()}");

                foreach (var student in item.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
                
            }
        }
    }
}
