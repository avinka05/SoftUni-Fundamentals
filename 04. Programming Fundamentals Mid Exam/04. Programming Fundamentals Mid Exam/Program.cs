using System;

namespace _04._Programming_Fundamentals_Mid_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            float food = float.Parse(Console.ReadLine())*1000;
            float hay = float.Parse(Console.ReadLine())*1000;
            float cover = float.Parse(Console.ReadLine())*1000;

            float weight = float.Parse(Console.ReadLine())*1000;
            
          
            for (int i = 1; i < 31; i++)
            {                 
                    food -= 300;

                    if (i % 2 == 0)
                    {
                        float amountOfHay = food * 0.05f;
                        hay -= amountOfHay;
                    }
                    if (i % 3 == 0)
                    {
                        cover -= weight * 0.333f;
                    }

                
                if (food <= 0 || hay <= 0 || cover <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
                  

            }
            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food/1000:f2}, Hay: {hay/1000:f2}, Cover: {cover/1000:f2}.");

        }
    }
}
