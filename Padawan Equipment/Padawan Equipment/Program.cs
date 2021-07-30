using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double cash = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceLightsabers = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());

            int countBelts = students;
            int freeBelts = 0;

            double countLightsabers = Math.Ceiling (students * 1.1) * priceLightsabers;
            while (countBelts >= 6)
            {
                freeBelts += 1;
                countBelts -= 6;
            }
            double finalPrice = countLightsabers + priceRobes * students + priceBelts * (students - freeBelts);
            double result = cash - finalPrice;
            if (result < 0)
            {
                Console.WriteLine($"Ivan Cho will need {Math.Abs(result):f2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {finalPrice:f2}lv.");
            }
        }
    }
}
