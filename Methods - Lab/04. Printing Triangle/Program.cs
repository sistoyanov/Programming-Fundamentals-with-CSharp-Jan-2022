using System;

namespace _04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int number = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= number ; rows++)
            {
                PrintColums(rows);
            }

            for (int rows = number - 1; rows >= 1; rows--)
            {
                PrintColums(rows);
            }
        }

        static void PrintColums(int rows)
        {
            for (int colums = 1; colums <= rows; colums++)
            {
                Console.Write(colums + " ");
            }
            Console.WriteLine();
        }
    }
}
