using System;
using System.Numerics;

namespace _02._Big_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger factorial = 1;
            int num = int.Parse(Console.ReadLine());

            for (int i = 2; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);

        }
    }
}
