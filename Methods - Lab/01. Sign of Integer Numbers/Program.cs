using System;

namespace _01._Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Print(number);
        }

        static void Print(int number)
        {
           string output = string.Empty;

            if (number > 0)
            {
                output = $"The number {number} is positive.";
            }
            else if (number < 0)
            {
                output = $"The number {number} is negative.";
            }
            else
            {
                output = $"The number {number} is zero.";
            }

            Console.WriteLine(output);
        }
    }
}
