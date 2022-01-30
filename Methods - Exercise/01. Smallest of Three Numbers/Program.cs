using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue;

            for (int i = 1; i <= 3; i++)
            {
                minNumber = SmallestNumber(minNumber);

            }
            Console.WriteLine(minNumber);
            
        }

        private static int SmallestNumber(int minNumber)
        {
            int number = int.Parse(Console.ReadLine());

            if (number < minNumber)
            {
                minNumber = number;
            }

            return minNumber;
        }
    }
}
