using System;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder numbers = new StringBuilder();
            StringBuilder chars = new StringBuilder();
            StringBuilder symbols = new StringBuilder();

            foreach (char item in input)
            {

                if (char.IsDigit(item))
                {
                    numbers.Append(item);
                }
                else if (char.IsLetter(item))
                {
                    chars.Append(item);
                }
                else if (!char.IsLetterOrDigit(item))
                {
                    symbols.Append(item);
                }

            }

            Console.WriteLine(numbers);
            Console.WriteLine(chars);
            Console.WriteLine(symbols);
        }
    }
}
