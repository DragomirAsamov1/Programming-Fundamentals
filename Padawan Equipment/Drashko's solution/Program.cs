using System;

namespace Drashko_s_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            double tourPrice = double.Parse(Console.ReadLine());
            int puzzleCount = int.Parse(Console.ReadLine());
            int dollsCount = int.Parse(Console.ReadLine());
            int bearsCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int trucksCount = int.Parse(Console.ReadLine());

            double puzzlePrice = puzzleCount * 2.6;
            double dollsPrice = dollsCount * 3;
            double bearsPrice = bearsCount * 4.1;
            double minionPrice = minionsCount * 8.2;
            double trucksPrice = trucksCount * 2;

            int totalCount = puzzleCount + dollsCount + bearsCount + minionsCount + trucksCount;
            double priceWon = puzzlePrice + dollsPrice + bearsPrice + minionPrice + trucksPrice;


            if (totalCount >= 50)
            {
                priceWon *= 0.75;
            }
            double money = priceWon* 0.9 - tourPrice;
            if (money>=0.0)
            {
                Console.WriteLine($"Yes! {money:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {money * -1:f2} lv needed.");
            }

        }
    }
}
