using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int oddSum = 0;
            int evenSum = 0;

            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenSum += num;
                }
                else
                {
                    oddSum += num;
                }
            }

            Console.WriteLine($"{evenSum - oddSum}");
        }
    }
}
