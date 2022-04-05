using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Morse_Code_Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, char> dictionary = new Dictionary<string, char>()
            {
                {".-", 'A'},
                {"-...", 'B'},
                {"-.-.", 'C'},
                {"-..", 'D'},
                {".", 'E'},
                {"..-.", 'F'},
                {"--.", 'G'},
                {"....", 'H'},
                {"..", 'I'},
                {".---", 'J'},
                {"-.-", 'K'},
                {".-..", 'L'},
                {"--", 'M'},
                {"-.", 'N'},
                {"---", 'O'},
                {".--.", 'P'},
                {"--.-", 'Q'},
                {".-.", 'R'},
                {"...", 'S'},
                {"-", 'T'},
                {"..-", 'U'},
                {"...-", 'V'},
                {".--", 'W'},
                {"-..-", 'X'},
                {"-.--", 'Y'},
                {"--..", 'Z'},
            };

            string[] input = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries);
            StringBuilder message = new StringBuilder();

            foreach (string item in input)
            {
                string[] word = item.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                foreach (string character in word)
                {
                    char currentChar;

                    if (dictionary.TryGetValue(character, out currentChar))
                    {
                        message.Append(currentChar);
                    }
                }

                message.Append(" ");
            }

            Console.WriteLine(message.ToString());
        }
    }
}
