using System;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int result = 0;
            while (num > 0)
            {
                int digit = num % 10;
                num /= 10;
                result += digit;
            }
            Console.WriteLine(result);
        }
    }
}
