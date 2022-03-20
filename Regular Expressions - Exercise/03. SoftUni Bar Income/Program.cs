using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            string pattern = @"\%(?<name>[A-Z]{1}[a-z]+)\%[^|$%.]*?\<(?<product>\w+)\>[^|$%.]*?\|(?<qantity>\d+)\|[^|$%.]*?(?<price>\d+(\.\d+)?)\$";
            decimal totalIncome = 0m;

            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match currentArg = Regex.Match(input, pattern);

                if (currentArg.Success)
                {
                    string customerName = currentArg.Groups["name"].Value;
                    string product = currentArg.Groups["product"].Value;
                    int quatity = int.Parse(currentArg.Groups["qantity"].Value);
                    decimal price = decimal.Parse(currentArg.Groups["price"].Value);
                    decimal totalPrice = quatity * price;
                    totalIncome += totalPrice;

                    Console.WriteLine($"{customerName}: {product} - {totalPrice:f2}");
                }
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
