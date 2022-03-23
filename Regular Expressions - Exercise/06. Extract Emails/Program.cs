using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(?<user>^([a-zA-Z0-9]+)([\.\-_]?)([A-Za-z0-9]+))@(?<host>([a-zA-Z]+([\.\-][A-Za-z]+)+))";
            // @"(^|(?<=\s))(([a-zA-Z0-9]+)([\.\-_]?)([A-Za-z0-9]+)(@)([a-zA-Z]+([\.\-][A-Za-z]+)+))(\b|(?=\s))";
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .ToArray();
            List<string> output = new List<string>();

            foreach (string item in input)
            {
                Match match = Regex.Match(item, regex);

                if (match.Success)
                {
                    output.Add(match.Value);
                }
            }

            Console.WriteLine(String.Join(Environment.NewLine, output));

        }
    }
}
