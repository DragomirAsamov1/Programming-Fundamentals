using System;

namespace Convert_meters_to_kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal distance = decimal.Parse(Console.ReadLine()) / 1000;
            Console.WriteLine($"{distance:f2}");
        }
    }
}
