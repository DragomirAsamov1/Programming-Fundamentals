﻿using System;
using System.Linq;

namespace Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(' ',Console.ReadLine().Split().Reverse()));
        }
    }
}
