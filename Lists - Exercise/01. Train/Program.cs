using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] currentCommand = command.Split(' ');

                if (currentCommand[0] == "Add")
                {
                    numbers.Add(int.Parse(currentCommand[1]));
                }
                else
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {

                        if (numbers[i] + int.Parse(currentCommand[0]) <= maxCapacity)
                        {
                            numbers[i] += int.Parse(currentCommand[0]);
                            break;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
