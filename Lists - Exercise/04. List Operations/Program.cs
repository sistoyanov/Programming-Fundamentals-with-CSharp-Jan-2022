using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] currentCommand = command.Split();

                if (currentCommand[0] == "Add")
                {
                    numbers.Add(int.Parse(currentCommand[1]));
                }
                else if (currentCommand[0] == "Insert")
                {
                    int currentIndex = int.Parse(currentCommand[2]);

                    if (currentIndex < numbers.Count && currentIndex >= 0)
                    {
                        numbers.Insert(currentIndex, int.Parse(currentCommand[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (currentCommand[0] == "Remove")
                {

                    int currentIndex = int.Parse(currentCommand[1]);

                    if (currentIndex < numbers.Count && currentIndex >= 0)
                    {
                        numbers.RemoveAt(currentIndex);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }

                }
                else if (currentCommand[0] == "Shift" && currentCommand[1] == "left")
                {
                     //int realNumberCount = int.Parse(currentCommand[2]) % numbers.Count;

                    for (int i = 0; i < int.Parse(currentCommand[2]); i++)
                    {
                        numbers.Add(numbers[0]);
                        numbers.RemoveAt(0);
                    }
                    
                }
                else if (currentCommand[0] == "Shift" && currentCommand[1] == "right")
                {
                    //int realNumberCount = int.Parse(currentCommand[2]) % numbers.Count;

                    for (int i = 0; i < int.Parse(currentCommand[2]); i++)
                    {
                        numbers.Insert(0, numbers[numbers.Count - 1]);
                        numbers.RemoveAt(numbers.Count - 1);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
