using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
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
            bool isChanged = false;

            while (command != "end")
            {
                string[] currentCommand = command.Split();

                if (currentCommand[0] == "Add")
                {
                    numbers.Add(int.Parse(currentCommand[1]));
                    isChanged = true;
                }
                else if (currentCommand[0] == "Remove")
                {
                    numbers.Remove(int.Parse(currentCommand[1]));
                    isChanged = true;
                }
                else if (currentCommand[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(currentCommand[1]));
                    isChanged = true;
                }
                else if (currentCommand[0] == "Insert")
                {
                    numbers.Insert(int.Parse(currentCommand[2]), int.Parse(currentCommand[1]));
                    isChanged = true;
                }
                else if (currentCommand[0] == "Contains")
                {
                    if (numbers.Contains(int.Parse(currentCommand[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (currentCommand[0] == "PrintEven")
                {
                    List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);
                    Console.WriteLine(String.Join(" ", evenNumbers));

                }
                else if (currentCommand[0] == "PrintOdd")
                {
                    List<int> oddNumbers = numbers.FindAll(x => x % 2 != 0);
                    Console.WriteLine(String.Join(" ", oddNumbers));
                }
                else if (currentCommand[0] == "GetSum")
                {
                    int sum = numbers.Sum();
                    Console.WriteLine(sum);
                }
                else if (currentCommand[0] == "Filter")
                {
                    List<int> output = new List<int>();

                    if (currentCommand[1] == "<")
                    {
                        output = numbers.FindAll(x => x < int.Parse(currentCommand[2]));
                    }
                    else if (currentCommand[1] == ">")
                    {
                        output = numbers.FindAll(x => x > int.Parse(currentCommand[2]));
                    }
                    else if (currentCommand[1] == ">=")
                    {
                        output = numbers.FindAll(x => x >= int.Parse(currentCommand[2]));
                    }
                    else if (currentCommand[1] == "<=")
                    {
                        output = numbers.FindAll(x => x <= int.Parse(currentCommand[2]));
                    }

                    Console.WriteLine(String.Join(" ", output));
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(isChanged ? String.Join(" ", numbers) : "");
        }
    }
}
