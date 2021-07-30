using System;

namespace Sum_of_odd_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 10: 
                case 7:
                case 6:
                case 3:
                case 2:
                default: Console.WriteLine("Not divisible");break;
            }
            if (number % 10 == 0)
            {
                Console.WriteLine("The number is divisible by 10");
            }
            else if (number % 7 == 0)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else if (number % 6 == 0)
            {
                Console.WriteLine("The number is divisible by 6");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine("The number is divisible by 2");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
