using System;

namespace Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr1 = new string[n];
            string[] arr2 = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] currentArr = Console.ReadLine().Split(" ");

                string indexZeroElement = currentArr[0];
                string indexFirstElement = currentArr[1];

                if (i % 2 == 0)
                {
                    arr1[i] = indexZeroElement;
                    arr2[i] = indexFirstElement;
                }
                else
                {
                    arr1[i] = indexFirstElement;
                    arr2[i] = indexZeroElement;
                }
            }
            Console.WriteLine(string.Join(' ',arr1));
            Console.WriteLine(string.Join(' ',arr2));
        }
    }
}
