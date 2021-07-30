using System;

namespace _01._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int startNumber = 1;

            int sum = CalculateSum(input, startNumber);

            Console.WriteLine(sum);
        }
        static int CalculateSum(int input, int startNumber)         //input = 5, startNumber = 1
        {
            int sum = startNumber;                                  //sum = 1

            if (startNumber<input)                                  //1<5 true
            {
                startNumber++;                                      //startNumber = 1+1
                return sum += CalculateSum(input, startNumber);     //return 1+ CalculateSum(5, 2) == 1+14
            }                                                       //return 2+ CalculateSUm(5, 3) == 2+12
            return sum;                                             //return 3+ CalculateSUm(5, 4) == 3+9
        }                                                           //return 4+ CalculateSUm(5, 5) == 4+5
    }                                                               //return 5
}
