using System;

namespace _11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int start = int.Parse(Console.ReadLine());
            if (num > 10)
            {
                Console.WriteLine($"{num} X {start} = {num * start}");
            }
            else
            {
                for (int i = start; i <= 10; i++)
                {
                    Console.WriteLine($"{num} X {i} = {num * i}");
                }
            }

        }
    }
}
