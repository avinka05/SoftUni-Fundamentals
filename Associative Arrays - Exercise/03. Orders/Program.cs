using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var check = new Dictionary<string, List<decimal>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();
                if (input[0] == "buy")
                {
                    break;
                }
                string product = input[0];
                decimal prise = decimal.Parse(input[1]);
                decimal quantity = decimal.Parse(input[2]);

                if (!check.ContainsKey(product))
                {
                    check[product] = new List<decimal>() {prise,quantity };
                }
                else
                {
                    check[product][0] = prise;
                    check[product][1] += quantity;

                }
            }

            foreach (var item in check)
            {
                Console.WriteLine($"{item.Key} -> {item.Value[0]*item.Value[1]}");
            }
        }
    }
}
