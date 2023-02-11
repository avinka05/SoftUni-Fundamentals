using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elemets = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).ToList();
            int moves = 0;
            string input;
          

            while ((input = Console.ReadLine()) != "end")
            { 
               
                string[] indexes = input.Split(' ');
                moves++;
                int firstIndex = int.Parse(indexes[0]);
                int secondIndex = int.Parse(indexes[1]);

               
                
               
                if (firstIndex != secondIndex && firstIndex >= 0 && secondIndex >= 0 &&firstIndex<elemets.Count && secondIndex < elemets.Count)
                {
                    if (elemets[firstIndex] == elemets[secondIndex])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {elemets[firstIndex]}!");
                        if (firstIndex > secondIndex)
                        {
                            elemets.RemoveAt(firstIndex);
                            elemets.RemoveAt(secondIndex);
                        }
                        else
                        {
                            elemets.RemoveAt(secondIndex);
                            elemets.RemoveAt(firstIndex);
                        }
                        if (elemets.Count == 0)
                        {
                            Console.WriteLine($"You have won in {moves} turns!");
                            return;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }

                }
                else
                {
                    elemets.Insert(elemets.Count / 2, $"-{moves}a");
                    elemets.Insert((elemets.Count / 2), $"-{moves}a");

                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    continue;
                }
            }

            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(String.Join(" ",elemets));

        }
    }
}
