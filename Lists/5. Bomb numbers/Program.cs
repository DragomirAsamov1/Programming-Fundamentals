using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Bomb_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> specialNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int sum = 0;
            int targetNumber = specialNumbers[0];
            numbers.Where(n=> specialNumbers[1]);
            numbers.RemoveRange(specialNumbers[0]), );
        }
    }
}
