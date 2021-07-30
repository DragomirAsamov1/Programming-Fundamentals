using System;

namespace English_Name_Of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {       
                int num = int.Parse(Console.ReadLine()) % 10;
                string digit = string.Empty;
                switch (num)
                {
                    case 0: digit = "zero"; break;
                    case 1: digit = "one"; break;
                    case 2: digit = "two"; break;
                    case 3: digit = "three"; break;
                    case 4: digit = "four"; break;
                    case 5: digit = "five"; break;
                    case 6: digit = "six"; break;
                    case 7: digit = "seven"; break;
                    case 8: digit = "eight"; break;
                    case 9: digit = "nine"; break;
                }
                Console.WriteLine(digit);
        }
    }
}
