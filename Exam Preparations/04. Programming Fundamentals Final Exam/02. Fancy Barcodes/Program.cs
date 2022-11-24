using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                Regex regex = new Regex(@"(\@\#+)([A-Z][A-Za-z0-9]{4,}[A-Z])(\@\#+)");
                Match match = regex.Match(input);
                
                if (match.Success)
                {
                    char[] digits = input.Where(x => char.IsDigit(x)).ToArray();

                    if (digits.Length == 0)
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {string.Join("", digits)}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }

            }
        }
    }
}
