﻿using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool isBigger = true;

            for (int i = 0; i < num.Length; i++)
            {
                int currentInt = num[i];
                for (int j = i+1; j < num.Length; j++)
                {
                    if (num[j] >=currentInt)
                    {
                        isBigger = false;
                        break;
                    }
                }
                if (isBigger)
                {
                    Console.Write(currentInt + " ");
                }
                isBigger = true;
            }
        }
    }
}
