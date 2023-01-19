using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(" ").Select(double.Parse).ToList();
            double average = Queryable.Average(numbers.AsQueryable());
           List<double> topNumbers = numbers.Where(n => n > average).OrderByDescending(n => n).Take(5).ToList();
            if (!topNumbers.Any())
            {
                Console.WriteLine("No");
            }
            else
            Console.WriteLine(string.Join(" ",topNumbers));
            //mundio e los i mi se kara che pisa bavno
            
            
        }
    }
}
