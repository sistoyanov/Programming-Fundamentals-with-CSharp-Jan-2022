using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int numbersSum = numbers.Sum();
            double avarageNum = (double)numbersSum / (double)numbers.Count;

            List<int> greaterNums = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > avarageNum)
                {
                    greaterNums.Add(numbers[i]);
                }
            }

            greaterNums.Sort();
            greaterNums.Reverse();

            if (greaterNums.Count > 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"{greaterNums[i]} ");
                }
            }
            else if (greaterNums.Count > 0)
            {
                Console.WriteLine(String.Join(" ", greaterNums));
            }
            else
            {
                Console.WriteLine("No");
            }
            

        }
    }
}
