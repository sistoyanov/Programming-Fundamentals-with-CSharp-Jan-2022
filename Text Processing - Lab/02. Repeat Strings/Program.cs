using System;
using System.Text;

namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            StringBuilder output = new StringBuilder();

            foreach (string word in words)
            {
                int wordLenth = word.Length;

                for (int i = 0; i < wordLenth; i++)
                {
                    output.Append(word);
                }
            }

            Console.WriteLine(output);
        }
    }
}
