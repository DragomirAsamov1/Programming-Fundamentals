using System;

namespace Work_stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 2, 1, 4, 5 };

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    int tmp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = tmp;
                    Console.WriteLine(arr[i]);
                }
            }

        }

    }
}
