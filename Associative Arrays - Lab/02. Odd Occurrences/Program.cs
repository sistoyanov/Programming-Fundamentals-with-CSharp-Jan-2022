using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> output = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string currentWord = word.ToLower();

                if (output.ContainsKey(currentWord))
                {
                    output[currentWord] += 1;
                }
                else
                {
                    output.Add(currentWord, 1);
                }
            }

            foreach (var word in output.Where(w => w.Value % 2 != 0))
            {
                Console.Write($"{word.Key} ");
            }
        }
    }
}
