using System;

namespace Cooking_Masterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            int countFlourPackage = students;
            int freeFlour = countFlourPackage / 5;

            double priceOfFlour = double.Parse(Console.ReadLine())*(students-freeFlour);
            double pricOfEgg = double.Parse(Console.ReadLine())*(10*students);
            double priceOfApron = (double.Parse(Console.ReadLine())* Math.Ceiling(students*1.2));

            double result = priceOfFlour + pricOfEgg + priceOfApron;

            if (result<=budget)
            {
                Console.WriteLine($"Items purchased for {result:f2}$.");
            }
            else
            {
                double negativeBallance = result - budget;
                Console.WriteLine($"{negativeBallance:f2}$ more needed.");
            }
            
        }
    }
}
