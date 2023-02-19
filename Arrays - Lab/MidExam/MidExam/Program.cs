using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Deck_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> list = Console.ReadLine().Split(", ").ToList();
                
               
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] command = Console.ReadLine().Split(", ");


                switch (command[0])
                {
                     case "Add":

                        string cardName = command[1];
                        if (list.Contains(cardName))
                        {
                            Console.WriteLine("Card is already in the deck");
                        }
                        else
                        {
                            Console.WriteLine("Card successfully added");
                            list.Add(cardName);
                        }
                        break;

                    case "Remove":
                        if (list.Contains(command[1]))
                        {
                            Console.WriteLine("Card successfully removed");
                            list.Remove(command[1]);
                        }
                        else
                        {
                            Console.WriteLine("Card not found");
                        }
                        break;

                    case "Remove At":
                        int index = int.Parse(command[1]);
                        if (index < 0 && index > list.Count - 1)
                        {
                            Console.WriteLine("Index out of range");
                        }
                        else
                        {
                            list.RemoveAt(index);
                            Console.WriteLine("Card successfully removed");
                        }
                        break;

                    case "Insert":
                        int indexInsert = int.Parse(command[1]);
                        string cardToInsert = command[2];

                        if (indexInsert < 0 || indexInsert > list.Count - 1)
                        {
                            Console.WriteLine("Index out of range");
                        }
                        else
                        {
                            if (list.Contains(cardToInsert))
                            {
                                Console.WriteLine("Card is already added");
                            }
                            else
                            {
                                list.Insert(indexInsert, cardToInsert);
                                Console.WriteLine("Card successfully added");
                            }
                        }

                        break;

                }
            }


            Console.WriteLine(string.Join(", ", list));
        }
    }
}