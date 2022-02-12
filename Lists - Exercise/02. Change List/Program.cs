using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] currentCommand = command.Split();

                if (currentCommand[0] == "Delete")
                {
                    numbers.RemoveAll(x => x == int.Parse(currentCommand[1]));
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
