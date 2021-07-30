using System;

namespace Sort_Array_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[int.Parse(Console.ReadLine())];
            int current = 0;

            for (int i = 0; i < num.Length; i++)
            {
                current = num[i];
                for (int j = 0; j < current; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
