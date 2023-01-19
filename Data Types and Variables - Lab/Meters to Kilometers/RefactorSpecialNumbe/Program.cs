using System;

namespace RefactorSpecialNumbe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
       
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int numberToChek = i;
                
                while (numberToChek > 0)
                {
                   sum += numberToChek % 10;
                   numberToChek = numberToChek / 10;
                }
               bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {isSpecial}");
               sum = 0;
                
            }

        }
    }
}
