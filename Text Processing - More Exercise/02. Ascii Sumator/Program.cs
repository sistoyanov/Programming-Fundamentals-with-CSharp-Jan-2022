using System;

namespace _02._Ascii_Sumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            char startChar = char.Parse(Console.ReadLine());
            char endChar = char.Parse(Console.ReadLine());
            char[] input = Console.ReadLine().ToCharArray();

            foreach (char item in input)
            {
                if (item > startChar && item < endChar)
                {
                    sum += item;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
