using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();

            for (int i = 1; i <= count; i++)
            {
                string currentWord = Console.ReadLine();
                string currentSynonym = Console.ReadLine();

                if (synonyms.ContainsKey(currentWord))
                {
                    synonyms[currentWord].Add(currentSynonym);
                }
                else
                {
                    synonyms.Add(currentWord, new List<string>() {currentSynonym});
                }   
            }

            foreach (var item in synonyms)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
