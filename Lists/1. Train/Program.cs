using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());
            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


            while (command[0].ToLower() != "end")
            {
                switch (command[0].ToLower())
                {
                    case "add":
                        wagons.Add(int.Parse(command[1]));
                        break;
                    default:
                        int passengers = int.Parse(command[0]);
                        for (int i = 0; i < wagons.Count; i++)
                        {
                            if (wagons[i] + passengers <= maxCapacity)
                            {
                                wagons[i] += passengers;
                                break;
                            }
                        }
                        break;
                }
                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine(string.Join(' ', wagons));
        }
    }
}
