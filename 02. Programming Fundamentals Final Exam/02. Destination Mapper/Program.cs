using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int totalPoints = 0;
            List<string> destinations = new List<string>();

            Regex regex = new Regex(@"(\=|\/)(?<destination>[A-Z][A-Za-z]{2,})(\1)");
            MatchCollection matches = regex.Matches(input);
            
            foreach (Match match in matches)
            {
                totalPoints += match.Groups["destination"].Value.Length;
                destinations.Add(match.Groups["destination"].Value);
            }

            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {totalPoints}");
        }
    }
}
