using System;

namespace _01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();
            string input = string.Empty;

            while ((input=Console.ReadLine())!="Travel")
            {
                string[] command=input.Split(");

                //•	"Add Stop:{index}:{string}":
                if (command[0]=="Add Stop")
                {
                    if (int.Parse(command[1])>=0&&int.Parse(command[1])<stops.Length)
                    {
                        stops = stops.Insert(int.Parse(command[1]), command[2]);
                    }

                    Console.WriteLine(stops);
                }
                //                •	"Remove Stop:{start_index}:{end_index}":
                // Remove the elements of the string from the starting index to the end index(inclusive)
                // if both indices are valid

                else if (command[0] == "Remove Stop")
                {
                    int endIndex = int.Parse(command[2]);

                    int startIndex = int.Parse(command[1]);
                    if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < stops.Length && int.Parse(command[2]) >= 0 && int.Parse(command[2]) < stops.Length)
                    {
                        stops = stops.Remove(startIndex,endIndex+1-startIndex);
                    }
                    Console.WriteLine(stops);
                }
                else if (command[0] == "Switch")
                {
                    var oldString = command[1];
                    var newString = command[2];
                    if (stops.Contains(oldString))
                    {
                        stops=stops.Replace(oldString, newString);
                    }
                    Console.WriteLine(stops);
                }
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
