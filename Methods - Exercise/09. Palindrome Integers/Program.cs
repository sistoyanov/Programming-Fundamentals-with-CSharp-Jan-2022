using System;
using System.Linq;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            
            while ((input = Console.ReadLine()) != "END")
            {
                char[] inputArray = input.ToArray();
                char[] reversedInputArray = inputArray.Reverse().ToArray();
                string reversedInput = string.Join("", reversedInputArray);

                if (String.Equals(input, reversedInput))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
