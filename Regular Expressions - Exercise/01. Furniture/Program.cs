using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @">>(?<furniture>[A-z]+)\<<(?<price>\d+.?\d*)!(?<quantity>\d+)";
            List<string> output = new List<string>();
            decimal totalPrice = 0;
            string input = String.Empty;

            while ((input = Console.ReadLine()) != "Purchase")
            {
                string furnutureArg = input;
                MatchCollection matches = Regex.Matches(input, regex);

                foreach (Match match in matches)
                {
                    string furnitureType = match.Groups["furniture"].Value;
                    decimal furniturePrice = decimal.Parse(match.Groups["price"].Value);
                    int furnitureQty = int.Parse(match.Groups["quantity"].Value);

                    output.Add(furnitureType);
                    decimal currentPrice = furniturePrice * furnitureQty;
                    totalPrice += currentPrice;
                }
            }

            Console.WriteLine("Bought furniture:");

            if (output.Count > 0)
            {
                Console.WriteLine(String.Join(Environment.NewLine, output));
            }

            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
