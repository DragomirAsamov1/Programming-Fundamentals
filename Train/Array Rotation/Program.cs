﻿using System;

namespace Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            int rotate = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotate; i++)
            {
                string еlementToRotate = arr[0];

                for (int j = 1; j < arr.Length; j++)
                {
                    string currentElement = arr[j];
                    arr[j - 1] = currentElement;
                }
                arr[arr.Length - 1] = еlementToRotate;
            }
            Console.WriteLine(string.Join(' ',arr));
        }
    }
}