using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal savings = decimal.Parse(Console.ReadLine());
            List<int> drumSet = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> intialQualityOfDrumSet = new List<int>(drumSet);
            //intialQualityOfDrumSet.AddRange();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int currentPower = int.Parse(input);

                for (int i = 0; i < drumSet.Count; i++)
                {
                    decimal newDrumPrice = intialQualityOfDrumSet[i] * 3;

                    drumSet[i] -= currentPower;

                    if (drumSet[i] <= 0)
                    {
                        if (newDrumPrice <= savings)
                        {
                            savings -= newDrumPrice;
                            drumSet[i] = intialQualityOfDrumSet[i];
                        }
                        else
                        {
                            drumSet.RemoveAt(i);
                            intialQualityOfDrumSet.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }

            Console.WriteLine(String.Join(" ", drumSet));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
