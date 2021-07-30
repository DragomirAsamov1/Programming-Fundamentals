using System;

namespace Leap_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            //int year = int.Parse(Console.ReadLine());
            //bool currentYear = DateTime.IsLeapYear(year);
            //Console.WriteLine(currentYear);
            //----------------------------------------------------

            //for (int year = 1994; year <= 2020; year++)
            //{
            //    if (DateTime.IsLeapYear(year))
            //    {
            //        Console.WriteLine("{0} is a leap year.",year);
            //        DateTime leapDay = new DateTime(year, 2, 29);
            //        DateTime nextYear = leapDay.AddYears(1);
            //        Console.WriteLine("   One year from {0} is {1}",
            //                  leapDay.ToString("d"),
            //                  nextYear.ToString("d"));
            //    }
            //}
            //----------------------------------------------------

            int year = int.Parse(Console.ReadLine());

            if (year%4==0)
            {
                Console.WriteLine("The {0} year is leap",year);
            }
            else
            {
                Console.WriteLine("The {0} year isn't leap", year);

            }

        }
    }
}
