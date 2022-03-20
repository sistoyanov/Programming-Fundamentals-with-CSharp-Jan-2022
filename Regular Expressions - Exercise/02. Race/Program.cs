using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> racers = new Dictionary<string, int>();
            string[] recersNames = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);
            string input = string.Empty;
            string pattern = @"[\w]";

            while ((input = Console.ReadLine()) != "end of race")
            {
                MatchCollection racerArg = Regex.Matches(input, pattern);
                int currentSum = 0;
                StringBuilder currentRacer = new StringBuilder();

                foreach (Match item in racerArg)
                {
                    if (char.IsDigit(char.Parse(item.Value)))
                    {
                        currentSum += char.Parse(item.Value) - '0';
                    }
                    else if (char.IsLetter(char.Parse(item.Value)))
                    {
                        currentRacer.Append(item.Value);
                    }

                }

                if (!racers.ContainsKey(currentRacer.ToString()) && recersNames.Any(n => n.Contains(currentRacer.ToString())))
                {
                    racers.Add(currentRacer.ToString(), currentSum);
                }
                else if (racers.ContainsKey(currentRacer.ToString()))
                {
                    racers[currentRacer.ToString()] += currentSum;
                }
            }

            racers = racers.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            int counter = 1;
            foreach (var kvp in racers)
            {
                if (counter == 1)
                {
                    Console.WriteLine($"{counter}st place: {kvp.Key}");
                    counter++;
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"{counter}nd place: {kvp.Key}");
                    counter++;
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"{counter}rd place: {kvp.Key}");
                    counter++;
                }
            }
        }
    }
}
