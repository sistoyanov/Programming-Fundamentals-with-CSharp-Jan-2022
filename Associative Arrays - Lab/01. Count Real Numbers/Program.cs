using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(number => int.Parse(number))
                .ToArray();

            SortedDictionary<int, int> output = new SortedDictionary<int, int>();

            foreach (var number in numbers)
            {
                if (output.ContainsKey(number))
                {
                    output[number] += 1;
                }
                else
                {
                    output.Add(number, 1);
                }
            }

            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
