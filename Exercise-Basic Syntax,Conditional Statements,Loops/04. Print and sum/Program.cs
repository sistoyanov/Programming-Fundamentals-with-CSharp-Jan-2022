using System;

namespace _04._Print_and_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            //action
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            //output
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
