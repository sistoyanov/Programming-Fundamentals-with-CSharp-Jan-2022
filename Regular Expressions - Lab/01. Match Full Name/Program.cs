using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b[A-Z][a-z]{1,} [A-Z][a-z]{1,}\b";
            string names = Console.ReadLine();
            MatchCollection matches = Regex.Matches(names, regex);
            StringBuilder output = new StringBuilder();

            foreach (Match match in matches)
            {
                output.Append($"{match} ");
            }

            Console.WriteLine(output.ToString());
        }
    }
}
