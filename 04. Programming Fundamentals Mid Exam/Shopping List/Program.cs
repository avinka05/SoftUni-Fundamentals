using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shopingList = Console.ReadLine().Split("!").ToList();
            string input = " ";

            while ((input=Console.ReadLine())!= "Go Shopping!")
            {
              
                List<string> comand = input.Split(" ").ToList();

                if (comand[0]== "Urgent")
                {
                    comand[1] = shopingList[0];
                }
                else if (comand[0] == "Unnecessary")
                {
                    shopingList.Remove(comand[1]);
                }
                else if (comand[0] == "Correct")
                {
                    if (shopingList.Contains(comand[1]))
                    {
                        int index = shopingList.FindIndex(i => i == comand[1]);
                           if (index!=-1)
                           {
                                 shopingList.Insert(index, comand[2]);
                                 shopingList.RemoveAt(index);
                           }
                    }
                        
                                                          
                }
                else if (comand[0] == "Rearrange")
                {
                    if (shopingList.Contains(comand[1]))
                    {
                        shopingList.Remove(comand[1]);
                        shopingList.Add(comand[1]);
                    }
                    
                }
            }
            Console.WriteLine(string.Join(", ",shopingList));
        }
    }
}
