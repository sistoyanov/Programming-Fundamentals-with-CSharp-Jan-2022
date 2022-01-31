using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(MiddleChar(input));

        }

        static string MiddleChar(string input)
        {
            string output = string.Empty;

            if (input.Length % 2 == 0)
            {
                output = input[(input.Length / 2) - 1].ToString() + input[input.Length / 2].ToString();
            }
            else
            {
                output = input[input.Length / 2].ToString();
            }

            return output;
        }
    }
}
