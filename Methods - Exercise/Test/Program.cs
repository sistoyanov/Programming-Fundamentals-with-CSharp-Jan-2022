using System;
using System.Linq;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] array = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            string[] currentComand = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            long splitIndex = long.Parse(currentComand[1]);

            int[] left = new int[splitIndex + 1];
            int[] right = new int[array.length - left.length];

            for (int i = 0; i < left.length; i++)
            {
                left[i] = array[i];
            }

            int nextIndex = 0;
            
            for (long i = splitIndex + 1; i < array.length; i++)
            {
                right[nextIndex] = array[i];
                nextIndex++;
            }

            for (int i = 0; i < right.length; i++)
            {
                array[i] = right[i];
            }

            for (int i = right.length; i < array.length; i++)
            {
                array[i] = left[i - right.length];
            }
        }
    }
}
