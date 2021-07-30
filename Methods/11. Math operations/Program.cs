﻿using System;
using System.Linq;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine(Calculate (num1, @operator, num2));
        }
        static double Calculate (double num1, string @operator, double num2)
        {
            double result = 0;
            switch (@operator)
            {
                case "+": result = num1 + num2;break;
                case "-": result = num1 - num2;break;
                case "*": result = num1 * num2;break;
                case "/": result = num1 / num2;break;

                default:
                    break;
            }
            return result;
        }
            
    }
}
