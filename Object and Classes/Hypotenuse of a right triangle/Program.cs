using System;

namespace Hypotenuse_of_a_right_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());

            double hypotenuse = Math.Sqrt(Math.Pow(sideA,2) + Math.Pow(sideB,2));
            Console.WriteLine(hypotenuse);
        }
    }
}
