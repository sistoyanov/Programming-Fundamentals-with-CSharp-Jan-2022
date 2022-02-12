using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = numbers[i].Trim();
            }

            List<string> output = new List<string>();

            foreach (var str in numbers)
            {
                output.AddRange(str.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList());
            }

            Console.WriteLine(string.Join(" ", output));
            

        }
    }
}
