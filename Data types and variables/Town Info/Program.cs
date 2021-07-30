using System;

namespace Town_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            long population = long.Parse(Console.ReadLine());
            int square = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {city} has population {population} and area {square} square km.");
        }
    }
}
