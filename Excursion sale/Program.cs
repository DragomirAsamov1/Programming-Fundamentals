using System;

namespace Excursion_sale
{
    class Program
    {
        static void Main(string[] args)
        {
            int countExcursionToSea = int.Parse(Console.ReadLine());
            int countExcursionToMountain = int.Parse(Console.ReadLine());
            double sum = 0.0;
            string command = "";

            while (command != "Stop")
            {
                if (command == "sea" && countExcursionToSea > 0)
                {
                    countExcursionToSea -= 1;
                    sum += 680;

                }
                else if (command == "mountain" && countExcursionToMountain > 0)
                {
                    countExcursionToMountain -= 1;
                    sum += 499;
                }
                if (countExcursionToMountain == 0 && countExcursionToSea == 0)
                {
                    Console.WriteLine("Good job! Everything is sold.");
                    Console.WriteLine($"Profit: {sum} leva.");
                    return;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Profit: {sum} leva.");
        }
    }
}
