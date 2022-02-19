using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();
            List<char> words = input.ToList();
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNum = numbers[i];
                int currentSum = 0;

                while (currentNum > 0)
                {
                    currentSum += currentNum % 10;
                    currentNum /= 10;
                }

                int currentIndex = currentSum;


                if (currentIndex > words.Count - 1)
                {
                    currentIndex = currentIndex - words.Count;
                }

                output.Append(words[currentIndex]);
                words.RemoveAt(currentIndex);

            }

            Console.WriteLine(output);
        }
    }
}
