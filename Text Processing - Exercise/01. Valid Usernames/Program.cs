using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter user names separated by commas: ");
        string input = Console.ReadLine();
        string[] usernames = input.Split(',')
                                   .Select(username => username.Trim())
                                   .Where(username => username.Length >= 3 && username.Length <= 16 &&
                                                      username.All(c => char.IsLetterOrDigit(c) || c == '-' || c == '_'))
                                   .ToArray();

        Console.WriteLine("Valid user names:");
        foreach (string username in usernames)
        {
            Console.WriteLine(username);
        } 
    }
}