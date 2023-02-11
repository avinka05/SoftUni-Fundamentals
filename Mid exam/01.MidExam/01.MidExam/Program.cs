using System;

namespace _01.MidExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double total = 0;
            while (input!= "special"&& input  != "regular")
            {
                double price = double.Parse(input);
                if (price<=0)
                {
                    Console.WriteLine("Invalid price!");
                    input = Console.ReadLine();
                    continue;
                }
                total += price;
                input = Console.ReadLine();
            }

            if (total==0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            double taxes= 0.2 * total;
            double finalPrice = total + taxes;
            
           
            if (input== "special")
            {
                double discount = 0.1 * finalPrice;
                finalPrice -= discount;
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {total:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {finalPrice:f2}$");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {total:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {finalPrice:f2}$");
            }
        }
    }
}
