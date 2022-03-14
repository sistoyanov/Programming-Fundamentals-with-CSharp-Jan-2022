using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = Console.ReadLine().ToCharArray();
            List<char> output = new List<char>();

            for (int i = 0; i < chars.Length - 1; i++)
            {
                if(chars[i] != chars[i + 1])
                {
                    output.Add(chars[i]);
                }

            }

            output.Add(chars[chars.Length - 1]);

            Console.WriteLine(String.Join("", output));
        }
    }
}
