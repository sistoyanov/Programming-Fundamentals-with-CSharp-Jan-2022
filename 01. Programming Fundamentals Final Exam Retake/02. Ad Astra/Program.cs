using System;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int totalCalories = 0;
            Regex regex = new Regex(@"(\||\#)(?<item>[A-Za-z]+\s?[A-Za-z]*)(\1)(?<date>[\d]{2}\/[\d]{2}\/[\d]{2})(\1)(?<calories>[\d]+)(\1)");
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                totalCalories += int.Parse(match.Groups["calories"].Value);
            }
            
            Console.WriteLine($"You have food to last you for: {totalCalories / 2000} days!");

            foreach (Match currentMatch in matches)
            {
                Console.WriteLine($"Item: {currentMatch.Groups["item"].Value}, Best before: {currentMatch.Groups["date"].Value}, Nutrition: {currentMatch.Groups["calories"].Value}");
            }
        }
    }
}
