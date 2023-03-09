using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var map=new Dictionary<string,List<decimal>>();


            for (int i = 0; i < number; i++)
            {
                string name = Console.ReadLine();
                decimal grade=decimal.Parse(Console.ReadLine());

                if (!map.ContainsKey(name))
                {
                    map[name] = new List<decimal>();
                }

                map[name].Add(grade);
            }

            foreach (var item in map)
            {
                decimal finalGrade = item.Value.Average();

                if (finalGrade>=4.50m)
                {
                    Console.WriteLine($"{item.Key} –> {finalGrade:f2}");
                }
            }

        }
    }
}
