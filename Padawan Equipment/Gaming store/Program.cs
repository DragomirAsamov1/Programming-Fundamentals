using System;

namespace Gaming_store
{
    class Program
    {
        static void Main(string[] args)
        {
            double ballance = double.Parse(Console.ReadLine());

            double Outfall4 = 39.99;
            double CS = 15.99;
            double Zplinter = 19.99;
            double Honored = 59.99;
            double RoverWatch = 29.99;
            double RoverWatchOrigins = 39.99;

            double moneySpent = 0.0;

            string command = Console.ReadLine();

            while (command != "Game Time")
            {
                if (ballance > 0)
                {
                    switch (command)
                    {
                        case "OutFall 4":
                            if (ballance < Outfall4)
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            else
                            {
                                Console.WriteLine("Bought" + " " + command);
                                ballance -= Outfall4;
                                moneySpent += Outfall4;
                            }
                            break;
                        case "CS: OG":
                            if (ballance < CS)
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            else
                            {
                                Console.WriteLine("Bought" + " " + command);
                                ballance -= CS;
                                moneySpent += CS;
                            }
                            break;
                        case "Zplinter Zell":
                            if (ballance < Zplinter)
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            else
                            {
                                Console.WriteLine("Bought" + " " + command);
                                ballance -= Zplinter;
                                moneySpent += Zplinter;
                            }
                            break;
                        case "Honored 2":
                            if (ballance < Honored)
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            else
                            {
                                Console.WriteLine("Bought" + " " + command);
                                ballance -= Honored;
                                moneySpent += Honored;
                            }
                            break;
                        case "RoverWatch":
                            if (ballance < RoverWatch)
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            else
                            {
                                Console.WriteLine("Bought" + " " + command);
                                ballance -= RoverWatch;
                                moneySpent += RoverWatch;
                            }
                            break;
                        case "RoverWatch Origins Edition":
                            if (ballance < RoverWatchOrigins)
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            else
                            {
                                Console.WriteLine("Bought" + " " + command);
                                ballance -= RoverWatchOrigins;
                                moneySpent += RoverWatchOrigins;
                            }
                            break;
                        default:
                            Console.WriteLine("Not Found");
                            break;
                    }
                }
                if (ballance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${moneySpent}. Remaining: ${ballance:f2}");
        }
    }
}
