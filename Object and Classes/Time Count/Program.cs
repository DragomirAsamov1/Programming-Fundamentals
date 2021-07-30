using System;

namespace Time_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            int miliSec = Environment.TickCount;
            int seconds = miliSec / 1000;
            int minutes = 0;
            int hours = 0;
            int days = 0;
            while (seconds>=60)
            {
                seconds -= 60;
                minutes++;
            }
            while (minutes>=60)
            {
                minutes -= 60;
                hours++;
            }
            while (hours>=24)
            {
                hours -= 24;
                days++;
            }


            

            Console.WriteLine($"{days} days, {hours} hours, {minutes} minutes, {miliSec}");
            //while (miliSec % 1000 >= 0)
            //{
            //    miliSec -= 1000;
            //    seconds++;
            //    if (seconds>=60)
            //    {
            //        seconds -= 60;
            //        minutes++;
            //    }
            //    if (minutes >=60)
            //    {

            //    }
            //}
        }
    }
}
