using System;

namespace _3Exact_Sum_of_number
{
    class Program
    {
        static void Main(string[] args)
        {
           int numbers=int.Parse(Console.ReadLine());
            decimal sum = 0m;
            while (numbers!=0)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum += number;
                numbers--;
            }
            Console.WriteLine(sum);
        }
    }
}
