using System;

namespace Day_Of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.DayOfWeek.ToString());
            Console.WriteLine(DateTime.Now.ToString("dddd"));
        }
    }
}
