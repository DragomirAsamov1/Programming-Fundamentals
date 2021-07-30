using System;

namespace Face_of_a_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double sideC = double.Parse(Console.ReadLine());

            double P = (sideA + sideB + sideC) / 2;

            double area = Math.Sqrt(P * (P - sideA) * (P - sideB) * (P - sideC));

        }
    }
}
