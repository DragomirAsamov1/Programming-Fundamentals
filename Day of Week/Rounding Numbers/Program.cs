using System;

namespace Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            string[] items = values.Split();
            double[] arr = new double[items.Length];

            for (int i = 0; i < items.Length; i++)
            {
                arr[i] = Math.Round(double.Parse(items[i]), MidpointRounding.AwayFromZero);
                Console.WriteLine(items[i] + " => " + arr[i]);
            }
        }
    }
}
