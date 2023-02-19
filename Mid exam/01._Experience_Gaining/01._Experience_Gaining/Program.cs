using System;

namespace _01._Experience_Gaining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double expNeeded = double.Parse(Console.ReadLine());
            int battles = int.Parse(Console.ReadLine());

            double totalExp = 0;
            int count = 0;

            for (int i = 1; i <= battles; i++)
            {
                double currentExp = double.Parse(Console.ReadLine());
                count++;
                totalExp += currentExp;

                if (count % 3 == 0)
                {
                    totalExp += currentExp * 0.15;
                }
                if (count % 5 == 0)
                {
                    totalExp -= currentExp * 0.10;
                }
                if (count % 15 == 0)
                {
                    totalExp += currentExp * 0.05;
                }
                if (totalExp >= expNeeded)
                {
                    break;
                }
            }

            if (totalExp >= expNeeded)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {count} battles.");
            }
            else
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {expNeeded - totalExp:f2} more needed.");
            }
        }
    }
}
