using System;
using System.Numerics;

namespace Exact_sum_of_real_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal result = 0;

            for (int i = 1; i <= n ; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                result += num;
            }
            Console.WriteLine(result);
        }
    }
}
