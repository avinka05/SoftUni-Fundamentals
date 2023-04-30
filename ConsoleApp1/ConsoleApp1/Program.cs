using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string spell = Console.ReadLine();

            string input = string.Empty;
            while ((input=Console.ReadLine())!= "Abracadabra")
            {
                string[] command = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Abjuration")
                {
                    spell = spell.ToUpper();
                    Console.WriteLine(spell);
                }
                else if (command[0] == "Necromancy")
                {
                    spell = spell.ToLower();
                    Console.WriteLine(spell);
                }
                else if (command[0] == "Illusion")
                {
                    //"Illusion {index} {letter}"
                    int index = int.Parse(command[1]);
                    char letter =char.Parse(command[2]);

                    if (index>=0&&index<spell.Length)
                    {
                        spell = spell.Substring(0, index) + letter + spell.Substring(index + 1);
                        Console.WriteLine("Done!");
                    }
                    else
                    {
                        Console.WriteLine("The spell was too weak.");
                    }
                }
                else if (command[0] == "Divination")
                {
                    //o	"Divination {first substring} {second substring}"
                    var firstSubstring = command[1];
                    var secondSubstring = command[2];
                    if (spell.Contains(firstSubstring))
                    {
                        spell = spell.Replace(firstSubstring, secondSubstring);
                    }
                    else
                    {
                        break;
                    }

                }
                else if (command[0] == "Alteration")
                {
                    //Alteration {substring}
                    string substring = command[1];
                    if (spell.Contains(substring))
                    {
                        spell = spell.Replace(substring, "");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("The spell did not work!");
                }


            }
        }
    }
}
