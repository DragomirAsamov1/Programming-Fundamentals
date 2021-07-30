using System;

namespace Passengers_Per_Flight
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int passengers = 0;
            double countFlyes = 0;
            string command = "";

            for (int i = 1; i <= num; i++)
            {
                string airlineName = Console.ReadLine();
                while (command != "Finish")
                {
                    passengers += int.Parse(Console.ReadLine());
                    countFlyes++;
                }
                double averagePassengers = Math.Floor(passengers / countFlyes);
                Console.WriteLine($"{airlineName}: {averagePassengers} passengers");
            }

        }
    }
}
