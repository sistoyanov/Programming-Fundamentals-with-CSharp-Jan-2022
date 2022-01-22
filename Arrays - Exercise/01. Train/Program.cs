using System;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] people = new int [count];
            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
                sum += people[i];
            }

            Console.Write(String.Join(" ", people));
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
