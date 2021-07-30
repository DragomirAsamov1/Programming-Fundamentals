using System;

namespace Drago_s_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            double bedPrice = double.Parse(Console.ReadLine());
            double toiletPrice = double.Parse(Console.ReadLine());

            double foodPrice = toiletPrice * 1.25;
            double toyPrice = foodPrice * 0.5;
            double vetPrice = toyPrice * 1.1;

            double totalCostPerMonth = toiletPrice + foodPrice + toyPrice + vetPrice;

            double unexpectedCosts = totalCostPerMonth * 0.05;

            double finalPriceForYear = bedPrice + 12 * totalCostPerMonth + 12 * unexpectedCosts;

            Console.WriteLine($"{finalPriceForYear:f2} lv.");

        }
    }
}
