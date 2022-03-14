using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] num1 = Console.ReadLine().ToCharArray();
            int num2 = int.Parse(Console.ReadLine());

            if (num2 == 0)
            {
                Console.WriteLine(0);
                return;
            }

            int decimalReminder = 0;
            int currentMultiplication = 0;

            List<int> result = new List<int>();

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                int currentDigit = num1[i] - 48; // - '0'
                currentMultiplication = currentDigit * num2;
                currentMultiplication += decimalReminder;
                result.Insert(0, (currentMultiplication % 10));
                decimalReminder = currentMultiplication / 10;
            }

            if (decimalReminder > 0)
            {
                result.Insert(0, (decimalReminder));
            }

            Console.WriteLine(string.Join("", result));
        }
    }
    
}
