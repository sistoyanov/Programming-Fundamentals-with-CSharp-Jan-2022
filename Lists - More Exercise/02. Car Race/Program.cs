using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Car_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            double carOneTime = 0;
            double carTwoTime = 0;

            int middleIndex = numbers.Count / 2;

            for (int i = 0; i < middleIndex; i++)
            {
                double currentNum = numbers[i];
                carOneTime += numbers[i];
                
                if (currentNum == 0)
                {
                    carOneTime *= 0.8; 
                }
            }

            for (int j = numbers.Count - 1; j > middleIndex; j--)
            {
                double currentNum = numbers[j];
                carTwoTime += numbers[j];

                if (currentNum == 0)
                {
                    carTwoTime *= 0.8;
                }
            }

            Console.WriteLine(carOneTime < carTwoTime ? $"The winner is left with total time: {Math.Round(carOneTime, 1)}" : $"The winner is right with total time: {Math.Round(carTwoTime, 1)}");
        }
    }
}
