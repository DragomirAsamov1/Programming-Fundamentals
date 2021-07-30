using System;

class ToyShop
{
    static void Main()
    {
        double vacationMoney = double.Parse(Console.ReadLine());
        double puzzleCount = double.Parse(Console.ReadLine());
        double speakingDollsCount = double.Parse(Console.ReadLine());
        double teddyBearCount = double.Parse(Console.ReadLine());
        double minionCount = double.Parse(Console.ReadLine());
        double truckCount = double.Parse(Console.ReadLine());

        double puzzlePay = puzzleCount * 2.60;
        double speakingDollPay = speakingDollsCount * 3.0;
        double teddyBearPay = teddyBearCount * 4.10;
        double minionPay = minionCount * 8.20;
        double truckPay = truckCount * 2.0;

        double moneyPay = puzzlePay + speakingDollPay + teddyBearPay + minionPay + truckPay;
        double totalCount = puzzleCount + speakingDollsCount + teddyBearCount + minionCount + truckCount;

        if (totalCount > 50)
        {
            double finalPrice = moneyPay - (moneyPay * 0.25);
            double naem = finalPrice * 0.1;
            double wonMoney = finalPrice - naem;

            if (wonMoney > vacationMoney)
            {
                double restMoney = wonMoney - vacationMoney;
                Console.WriteLine($"Yes! {restMoney:f2} lv left.");
            }
            else
            {
                double restMoney = vacationMoney - wonMoney;
                Console.WriteLine($"Not enough money! {restMoney:f2} lv needed.");
            }
        }
        else
        {
            double finalPrice = moneyPay;
            double naem = finalPrice * 0.1;
            double wonMoney = finalPrice - naem;

            if (wonMoney > vacationMoney)
            {
                double restMoney = wonMoney - vacationMoney;
                Console.WriteLine($"Yes! {restMoney:f2} lv left.");
            }
            else
            {
                double restMoney = vacationMoney - wonMoney;
                Console.WriteLine($"Not enough money! {restMoney:f2} lv needed.");
            }

        }
    }
}