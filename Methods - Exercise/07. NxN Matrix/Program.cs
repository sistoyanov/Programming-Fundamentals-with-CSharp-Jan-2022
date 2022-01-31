using System;

namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int row = 1; row <= input; row++)
            {
                for (int column = 1; column <= input; column++)
                {
                    Console.Write($"{input} ");
                }
                Console.WriteLine();
            }
        }
    }
}
