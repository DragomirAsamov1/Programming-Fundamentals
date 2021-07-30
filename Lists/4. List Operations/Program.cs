using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (command[0].ToLower() != "end")
            {
                switch (command[0].ToLower())
                {
                    case "add":
                        nums.Add(int.Parse(command[1]));
                        break;
                    case "insert":
                        if (int.Parse(command[2]) >= nums.Count || int.Parse(command[2]) < 0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            nums.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        }
                        
                        break;
                    case "remove":
                        if (int.Parse(command[1]) >= nums.Count || int.Parse(command[1]) < 0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            nums.RemoveAt(int.Parse(command[1]));
                        }
                        break;
                }
                switch (command[1].ToLower())
                {
                    case "left":
                        for (int i = 0; i < int.Parse(command[2]); i++)
                        {
                            nums.Insert(nums[nums.Count - 1], nums[0]);
                            nums.RemoveAt(nums[nums.Count - 1]);
                        }
                        //ShiftLeft(nums, int.Parse(command[2]));
                        break;
                    case "right":
                        for (int i = 0; i < int.Parse(command[2]); i++)
                        {
                            nums.Add(nums[0]);
                            nums.RemoveAt(0);
                        }
                        //ShiftRight(nums, int.Parse(command[2]));
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine(string.Join(" ", nums));
        }
        /*static void ShiftLeft(List<int> nums, int count)
        {
            for (int i = 0; i < count; i++)
            {
                nums.Add(nums[0]);
                nums.RemoveAt(0);
            }
        }
        static void ShiftRight(List<int> nums, int count)
        {
            for (int i = 0; i < count; i++)
            {
                nums.Insert(nums[nums.Count - 1], nums[0]);
                nums.RemoveAt(nums[nums.Count - 1]);
            }
        }*/
    }
}
