using System;

namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            decimal sum = 0;

            foreach (string item in words)
            {
                char firstChar = item[0];
                char lastChar = item[item.Length - 1];
                decimal num = decimal.Parse(item.Substring(1, item.Length - 2));

                sum += CalculateNum(num, firstChar, lastChar);
            }

            Console.WriteLine($"{sum:f2}");
        }

        static decimal CalculateNum (decimal num, char firstChar, char lastChar)
        {
            decimal currentSum = 0;
            
            if (FindIsCharUpper(firstChar))
            {
                currentSum = num / FindCharAlfabetPosition(firstChar);
            }
            else
            {
                currentSum = num * FindCharAlfabetPosition(firstChar);
            }

            if (FindIsCharUpper(lastChar))
            {
                currentSum -= FindCharAlfabetPosition(lastChar);
            }
            else
            {
                currentSum += FindCharAlfabetPosition(lastChar);
            }

            return currentSum;
        }

        static bool FindIsCharUpper (char currentChar)
        {
            if (char.IsUpper(currentChar))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        static decimal FindCharAlfabetPosition(char currentChr)
        {
            currentChr = char.ToLower(currentChr);
            decimal positon = currentChr - 96;
            return positon;
        }

    }
}
