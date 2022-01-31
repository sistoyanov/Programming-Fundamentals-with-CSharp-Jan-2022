using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long numA = long.Parse(Console.ReadLine());
            long numB = long.Parse(Console.ReadLine());

            double num1 = ClaculateFactorial(numA);
            double num2 = ClaculateFactorial(numB);

            Console.WriteLine($"{(num1 / num2):f2}");
        }

        static double ClaculateFactorial(long number)
        {

            for (long i = number - 1; i > 0; i--)
            {
                number *= i;
            }


            return number;
        }
    }
}
