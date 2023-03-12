using System.Text;
using System;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();

            StringBuilder sb = new StringBuilder();
            foreach (var word in array)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    sb.Append(word);
                }
            }

            string result = sb.ToString();
            Console.WriteLine(result);


        }
    }
}
