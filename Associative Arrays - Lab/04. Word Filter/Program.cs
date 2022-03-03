using System;
using System.Linq;

namespace _04._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ouput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(word => word.Length % 2 == 0)
                .ToArray();

            foreach (var word in ouput)
            {
                Console.WriteLine(word);
            }
        }
    }
}
