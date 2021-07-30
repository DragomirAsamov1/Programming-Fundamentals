using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert your card");

            double amount = 1050, withdraw, deposit;
            int choice, pin = 0000;
            Console.WriteLine("Welcome to bank ATM service\n");
            Console.WriteLine("1. Current Balance\n");
            Console.WriteLine("2. Withdraw\n");
            Console.WriteLine("3. Deposit\n");
            Console.WriteLine("4. Change PIN code\n");
            Console.WriteLine("******************************\n");
            Console.WriteLine("Enter your choice:");

            choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your PIN:");
            int pincheck = int.Parse(Console.ReadLine());

            if (pincheck == pin)
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"{amount:f2}");
                        break;
                    case 2:
                        Console.WriteLine("Enter the withdraw amount:");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw % 100 != 0)
                        {
                            Console.WriteLine("Please enter the amount in above 100");
                        }
                        else if (withdraw > amount)
                        {
                            Console.WriteLine("Sorry! Insufficient balance");
                        }
                        else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine("Please collect your cash");
                            Console.WriteLine($"Current balance is {amount:f2}");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter the deposit amount");
                        deposit = int.Parse(Console.ReadLine());
                        amount += deposit;
                        Console.WriteLine("Your amount has been deposited succesfilly");
                        Console.WriteLine($"Your total balance is: {amount:f2}");
                        break;
                    case 4:
                        Console.WriteLine("Enter new PIN code:");
                        pin = int.Parse(Console.ReadLine());
                        Console.WriteLine($"You succesfull change your PIN code to {pin}");
                        break;
                    default:
                        break;
                }
            }
            
        }
    }
}
