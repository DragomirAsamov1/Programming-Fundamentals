﻿using System;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int countWagon = int.Parse(Console.ReadLine());
            int[] people = new int[countWagon];
            int sum = 0;
            for (int i = 0; i < countWagon; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
                sum += people[i];
            }
            Console.WriteLine(string.Join(' ', people));
            Console.WriteLine(sum);
        }
    }
}
