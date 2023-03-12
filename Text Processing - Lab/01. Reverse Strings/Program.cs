using System;
using System.Text;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            while ((input=Console.ReadLine())!="end")
            {
                StringBuilder reversedWord=new StringBuilder();
                for (int i = input.Length-1; i >= 0; i--)
                {
                    reversedWord.Append(input[i]);
                }
                string result = reversedWord.ToString();

                Console.WriteLine($"{input} = {result}");
            }
        }
    }
}
