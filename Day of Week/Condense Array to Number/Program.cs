using System;
using System.Linq;

namespace Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstLength = num.Length - 1;

            int i = 0;
            int sum = 0;
            while (i < firstLength)
            {
                int[] condesded = new int[num.Length - 1];
                condesded[i] = num[i] + num[i] + 1;
                num = condesded;
                sum = condesded[i];
                i++;
            }
            Console.WriteLine(sum);
        }
    }
}
