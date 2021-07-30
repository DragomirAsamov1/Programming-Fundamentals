using System;

namespace Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnum = int.Parse(Console.ReadLine());
            int secondnum = int.Parse(Console.ReadLine());

            for (int i = firstnum; i <= secondnum; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
