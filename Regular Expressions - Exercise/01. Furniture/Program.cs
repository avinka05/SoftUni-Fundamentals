using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var items = new List<string>();
            decimal totalPrice = 0;

            
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Regex regex = new Regex(@">>(?<iteam>[A-Za-z]+)<<(?<price>\d+.\d+)!(?<quantity>\d)>>(?<iteam>[A-Za-z]+)<<(?<price>\d+(.\d+))!(?<quantity>\d)");
                var match = regex.Match(input);

                if (match.Success)
                {
                    var name = match.Groups["iteam"].Value;
                    var price = decimal.Parse(match.Groups["price"].Value);
                    var quantity = decimal.Parse(match.Groups["quantity"].Value);

                    items.Add(name);
                    totalPrice += price * quantity;
                }
            }
          
        }
    }
}
