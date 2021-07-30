using System;
using System.Collections.Generic;
using System.Text;

namespace SU
{
    class Subscription
    {
        List<Issue> periodical = new List<Issue> { };
        public Subscription(Subscription m)
        {

        }

        public static Subscription operator +(Subscription s, Issue i) 
        {
            s.periodical.Add(i);
            return s;
        }

        public void PrintIssues()
        {
            foreach (Issue a in periodical)
            {
                Console.WriteLine(a);
            }
        }

        public double CalculatePrice(double discountPercent, double priceOver)
        {
            double totalPrice = 0.0;
            foreach (Issue i in periodical)
            {
                if  (i.Price > priceOver)
                {
                    //
                    // Calculate Discount
                    //
                    totalPrice += i.Price * (discountPercent / 100);

                } 
                else
                { 
                    totalPrice += i.Price;
                }
            }

            return totalPrice;
        }
    }
    class UnreachableCode
    {
        public void MyMethod(int a, int b)
        {
            if (a==b)
            {
                Console.WriteLine("Вярно е");
                return;
            }
            else
            {
                Console.WriteLine("Не е вярно");
                return;
            }
            Console.WriteLine("Този код е недостъпен");
        }
    }

}
