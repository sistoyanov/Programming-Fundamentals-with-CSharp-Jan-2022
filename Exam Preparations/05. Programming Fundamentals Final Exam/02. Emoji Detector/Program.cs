using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"(\:\:|\*\*)(?<emoji>[A-Z][a-z]{2,})(\1)");
            char[] numbers = input.Where(c => char.IsDigit(c)).ToArray();

            int coolThreshold = 1;
            foreach (char character in numbers)
            {
                int currentNumber = character - '0';
                coolThreshold *= currentNumber;
            }

            MatchCollection matches = regex.Matches(input);
            List<string> coolEmojies = new List<string>();

            foreach (Match match in matches)
            {
                char[] currentEmoji = match.Groups["emoji"].Value.ToCharArray();
                int sum = currentEmoji.Sum(c => c);

                if (sum >= coolThreshold)
                {
                    coolEmojies.Add(match.ToString());
                }
      
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");
            foreach (string emoji in coolEmojies)
            {
                Console.WriteLine(emoji);
            }
        }
    }
}
