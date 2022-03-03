using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<char, int> chars = new Dictionary<char, int>();

            foreach (var word in words)
            {
                char[] currentCahrs = word.ToCharArray();

                foreach (char item in currentCahrs)
                {

                    if (chars.ContainsKey(item))
                    {
                        chars[item] += 1;
                    }
                    else
                    {
                        chars.Add(item, 1);
                    }

                }
            }

            foreach (var item in chars)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
