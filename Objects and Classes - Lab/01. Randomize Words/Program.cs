using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            Random random = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                int minValue = 0;
                int maxValue = words.Count - 1;
                int currentNum = random.Next(minValue, maxValue);

                string currentWord = words[i];
                words[i] = words[currentNum];
                words[currentNum] = currentWord;
            }

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
