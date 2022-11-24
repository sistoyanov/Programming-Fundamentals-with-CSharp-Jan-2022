using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> neigborhood = Console.ReadLine()
                .Split('@', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = string.Empty;
            int currentIndex = 0;

            while ((input = Console.ReadLine()) != "Love!")
            {
                string[] commandArg = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int lenght = int.Parse(commandArg[1]);

                currentIndex += lenght;

                if (currentIndex < 0 || currentIndex > neigborhood.Count - 1)
                {
                    currentIndex = 0;
                }

                if (neigborhood[currentIndex] == 0)
                {
                    Console.WriteLine($"Place {currentIndex} already had Valentine's day.");
                    continue;
                }

                neigborhood[currentIndex] -= 2;

                if (neigborhood[currentIndex] == 0)
                {
                    Console.WriteLine($"Place {currentIndex} has Valentine's day.");
                }
            }
           
            Console.WriteLine($"Cupid's last position was {currentIndex}.");

            int counter = 0;

            foreach (var item in neigborhood)
            {
                if (item > 0)
                {
                    counter++;
                }
            }

            if (counter > 0)
            {
                Console.WriteLine($"Cupid has failed {counter} places.");
            }
            else
            {
                Console.WriteLine($"Mission was successful.");
            }
        }
    }
}
