using System;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int capacity = 255;
            int currentCapacity = 0;
            for (int i = 1; i <= lines; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                
                if (capacity<liters)
                {  
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    currentCapacity += liters;
                    capacity -= liters;
                }
            }
            Console.WriteLine(currentCapacity);
        }
    }
}
