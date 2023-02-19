using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Deck_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listet = Console.ReadLine()
                .Split(", ")
                .ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(", ");


                switch (command[0])
                {
                    case "Add":
                        string cardName = command[1];
                        if (listet.Contains(cardName))
                        {
                            Console.WriteLine("Card is already bought");
                        }
                        else
                        {
                            Console.WriteLine("Card successfully bought");
                            listet.Add(cardName);
                        }
                        break;
                    case "Remove":
                        if (listet.Contains(command[1]))
                        {
                            Console.WriteLine("Card successfully sold");
                            listet.Remove(command[1]);
                        }
                        else
                        {
                            Console.WriteLine("Card not found");
                        }
                        break;
                    case "Remove At":
                        int index = int.Parse(command[1]);
                        if (index < 0 && index > listet.Count - 1)
                        {
                            Console.WriteLine("Index out of range");
                        }
                        else
                        {
                            listet.RemoveAt(index);
                            Console.WriteLine("Card successfully sold");
                        }
                        break;
                    case "Insert":
                        int indexInsert = int.Parse(command[1]);
                        string cardInsert = command[2];

                        if (indexInsert < 0 && indexInsert > listet.Count - 1)
                        {
                            Console.WriteLine("Index out of range");
                        }
                        else
                        {
                            if (listet.Contains(cardInsert))
                            {
                                Console.WriteLine("Card is already bought");
                            }
                            else
                            {
                                listet.Insert(indexInsert, cardInsert);
                                Console.WriteLine("Card successfully bought");
                            }
                        }

                        break;

                }
            }

            Console.WriteLine(string.Join(", ", listet));
        }
    }
}