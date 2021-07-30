using System;
using System.Collections.Generic;

namespace _3._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int listCount = int.Parse(Console.ReadLine());
            List <string> guests = new List<string>();
            for (int i = 0; i < listCount; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(' ', StringSplitOptions
                    .RemoveEmptyEntries);
                string guestName = command[0];
                if (command.Length>3)
                {
                    if (guests.Contains(guestName))
                    {
                        guests.Remove(guestName);
                    }
                    else
                    {
                        Console.WriteLine($"{guestName} is not in the list!");
                    }
                }
                else
                {
                    if (guests.Contains(guestName))
                    {
                        Console.WriteLine($"{guestName} is already in the list!");
                    }
                    else
                    {
                        guests.Add(guestName);
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, guests));
        }
    }
}
