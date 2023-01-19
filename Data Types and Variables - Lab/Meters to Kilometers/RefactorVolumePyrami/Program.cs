using System;

namespace RefactorVolumePyrami
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Length: ");
            double lenth = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Heigt: ");
            double height= double.Parse(Console.ReadLine());
            
            double volume= (lenth * width * height) / 3;

            Console.Write($"Pyramid Volume: {volume:f2}");

        }
    }
}
