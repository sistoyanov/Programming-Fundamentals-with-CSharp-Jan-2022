using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"(\@|\#)(?<first>[A-za-z]{3,})(\1){2}(?<second>[A-za-z]{3,})(\1)");
            MatchCollection matches = regex.Matches(input);

            List<string> pairs = new List<string>();

            foreach (Match match in matches)
            {
                string firstWord = match.Groups["first"].Value;
                string secondWord = match.Groups["second"].Value;

                char[] charArray = secondWord.ToCharArray();
                Array.Reverse(charArray);
                string reversedSecondWord = new string(charArray);

                if (firstWord == reversedSecondWord)
                {
                    pairs.Add($"{firstWord} <=> {secondWord}");
                }
            }

            Console.WriteLine(matches.Count > 0 ? $"{matches.Count} word pairs found!" : "No word pairs found!");

            if (pairs.Count > 0)
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(String.Join(", ", pairs));
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
