using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> targets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] commandArg = input.Split(" ");
                string command = commandArg[0];
                int index = int.Parse(commandArg[1]);

                if (command == "Shoot")
                {
                    int power = int.Parse(commandArg[2]);

                    if (!IsIndexValid(targets, index))
                    {
                        continue;
                    }
                    else
                    {
                        targets[index] -= power;

                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (command == "Add")
                {
                    int value = int.Parse(commandArg[2]);

                    if (!IsIndexValid(targets, index))
                    {
                        Console.WriteLine("Invalid placement!");
                        continue;
                    }
                    else
                    {
                        targets.Insert(index, value);
                    }
                }
                else if (command == "Strike")
                {
                    int radius = int.Parse(commandArg[2]);
                    int startIndex = index - radius;
                    int endIndex = index + radius;

                    if (!IsIndexValid(targets, startIndex) || !IsIndexValid(targets, endIndex))
                    {
                        Console.WriteLine("Strike missed!");
                        continue;
                    }
                    else
                    {
                        targets.RemoveRange(index + 1, radius);
                        targets.RemoveRange(startIndex, radius + 1);
                    }
                }
            }

            Console.WriteLine(String.Join("|", targets));
        }

        static bool IsIndexValid (List<int> targets, int index)
        {
            if (index < 0 || index > targets.Count - 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
