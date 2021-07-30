using System;

namespace _02._Factorial_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int result = Factorial(n);

            Console.WriteLine(result);
        }
        static int Factorial(int n)             //Factorial (5)
        {
            if (n==0)                           //if (5==0) --->false
            {
                return 1; 
            }
            else
            {
                return n * Factorial(n - 1);    //return 5* Factorial (4) == 5*24 = 120
            }                                   //return 4* Factorial (3) == 4*6 = 24
        }                                       //return 3* Factorial (2) == 3*2 = 6
    }                                           //return 2* Factorial (1) == 2*1 = 2
}                                               //return 1* Factorial (0) == 1
