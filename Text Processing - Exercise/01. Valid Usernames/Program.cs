using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] validUserNames = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Where(x =>( x.Length >= 3 && x.Length <= 16 )&& Regex.IsMatch(x, @"^[A-Za-z0-9_-]+$"))
                .ToArray();

            foreach (var item in validUserNames)
            {
   
        }
        
    }
}
