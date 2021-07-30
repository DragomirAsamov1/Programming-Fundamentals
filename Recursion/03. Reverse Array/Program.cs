using System;
using System.Linq;

namespace _03._Reverse_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            for (int i = arr.Length-1; i >= 0; i--)
            {
                Console.Write(string.Join(" ",arr[i]));
            }
        }
    }
}
