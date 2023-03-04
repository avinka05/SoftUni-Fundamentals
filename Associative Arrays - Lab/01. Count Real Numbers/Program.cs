using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            SortedDictionary<int, int> values = new SortedDictionary<int, int>();

            foreach (var number in numbers)
            {
                if (!values.ContainsKey(number))
                {
                    values.Add(number, 0);
                }

                values[number]++;
                    
            }
            foreach (var (key,value) in values)
            {
                Console.WriteLine($"{key} -> {value}");
            }
        }
    }
}
