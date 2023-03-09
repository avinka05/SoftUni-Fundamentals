using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var map = new Dictionary<string, string>();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string command = input[0];
                string username = input[1];

                if (command== "register")
                {
                    
                    string licensePlateNumber = input[2];

                    if (!map.ContainsKey(username))
                    {
                        map[username] = licensePlateNumber;
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                    
                }
                else
                {
                    if (!map.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        map.Remove(username);

                        Console.WriteLine($"{username} unregistered successfully");
                    }
                                
                }
            }


            foreach (var item in map)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }

        }
    }
}
