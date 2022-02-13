using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int sum = 0;

            while(numbers.Count > 0)
            {
                int currentIndex = int.Parse(Console.ReadLine());
                int currentNum = 0;

                if (currentIndex >= 0 && currentIndex < numbers.Count)
                {
                    currentNum = numbers[currentIndex];
                    sum += currentNum;
                    numbers.RemoveAt(currentIndex);
                    IncreaseAndDecreaseNumbers(numbers, currentNum);
                }
                else if (currentIndex < 0)
                {
                    currentNum = numbers[0];
                    sum += currentNum;
                    numbers.RemoveAt(0);
                    numbers.Insert(0, numbers[numbers.Count - 1]);
                    IncreaseAndDecreaseNumbers(numbers, currentNum);
                }
                else if (currentIndex > numbers.Count - 1)
                {
                    currentNum = numbers[numbers.Count - 1];
                    sum += currentNum;
                    numbers.RemoveAt(numbers.Count - 1);
                    numbers.Add(numbers[0]);
                    IncreaseAndDecreaseNumbers(numbers, currentNum);
                }

            }

            Console.WriteLine(sum);
        }

       static void IncreaseAndDecreaseNumbers(List<int> numbers, int currentNum)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] <= currentNum)
                {
                    numbers[i] += currentNum;
                }
                else
                {
                    numbers[i] -= currentNum;
                }
            }
        }
    }
}
