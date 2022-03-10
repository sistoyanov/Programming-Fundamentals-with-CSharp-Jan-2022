using System;

namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string currentWord = input;
                char[] reverseWord = input.ToCharArray();
                Array.Reverse(reverseWord);

                Console.WriteLine($"{currentWord} = {String.Join("", reverseWord)}");
            }
        }
    }
}
