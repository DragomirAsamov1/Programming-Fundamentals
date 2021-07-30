using System;

namespace Ten_Random_Numbers
{
    class RandomNumbersGenerator
    {
        static void Main(string[] args)
        {
            int minNum = 100;
            int maxNum = 200;
            Random rnd = new Random();
            int currentNum;
            for (int i = 0; i < 10; i++)
            {
                currentNum=(rnd.Next(minNum, maxNum + 1));
                Console.WriteLine(currentNum);

            }
        }
    }
}
