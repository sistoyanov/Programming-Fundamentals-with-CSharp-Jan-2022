using System;
using System.Linq;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            int num = Math.Abs(int.Parse(numbers.ToString()));

            Console.WriteLine(GetMultipleOfEvenAndOdds(num));

        }

        private static int GetMultipleOfEvenAndOdds(int num)
        {
            int sumOfEven = 0;
            int sumOfOdd = 0;

            while (num > 0)
            {
                int currentNum = num % 10;

                if (currentNum % 2 == 0)
                {
                    sumOfEven += currentNum;
                }
                else
                {
                    sumOfOdd += currentNum;
                }

                num /= 10;
            }

            return sumOfEven * sumOfOdd;
        }

    }
}
