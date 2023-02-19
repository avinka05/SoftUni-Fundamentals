using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Coffee_Lover
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> coffee = Console.ReadLine().Split().ToList();
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string command = Console.ReadLine();
                string[] tokens = command.Split();
                string action = tokens[0];

                switch (true)
                {
                    case "Include":
                        string coffeeToInclude = tokens[1];
                        coffee.Add(coffeeToInclude);
                        break;

                    case "Remove":
                        int numberOfCoffees = int.Parse(tokens[2]);
                        if (coffee.Count < numberOfCoffees)
                        {
                            break;
                        }

                        if (tokens[1] == "first")
                        {
                            for (int j = 0; j < numberOfCoffees; j++)
                            {
                                coffee.RemoveAt(0);
                            }
                        }

                        if (tokens[1] == "last")
                        {
                            for (int j = 0; j < numberOfCoffees; j++)
                            {
                                coffee.RemoveAt(coffee.Count - 1);
                            }
                        }
                        break;
                    case "Prefer":
                        int coffeeIndex = int.Parse(tokens[1]);
                        int coffeeIndex2 = int.Parse(tokens[2]);

                        if (coffeeIndex >= 0 && coffeeIndex <= coffee.Count - 1 && coffeeIndex2 >= 0 && coffeeIndex2 <= coffee.Count - 1)
                        {
                            Swap(coffeeIndex, coffeeIndex2, coffee);

                        }
                        break;
                    case "Reverse":
                        coffee.Reverse();
                        break;

                }
            }
            Console.WriteLine("Coffees:");
            Console.WriteLine(string.Join(' ', coffee));


        }
        static void Swap(int firstIndex, int secondIndex, List<string> numbers)
        {
            string temp = numbers[firstIndex]; ;
            numbers[firstIndex] = numbers[secondIndex];
            numbers[secondIndex] = temp;
        }
    }

}

