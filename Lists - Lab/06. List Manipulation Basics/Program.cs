using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] currentCommand = command.Split();

                if (currentCommand[0] == "Add")
                {
                    numbers.Add(int.Parse(currentCommand[1]));
                }
                else if (currentCommand[0] == "Remove")
                {
                    numbers.Remove(int.Parse(currentCommand[1]));
                }
                else if (currentCommand[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(currentCommand[1]));
                }
                else if (currentCommand[0] == "Insert")
                {
                    numbers.Insert(int.Parse(currentCommand[2]), int.Parse(currentCommand[1]));
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
