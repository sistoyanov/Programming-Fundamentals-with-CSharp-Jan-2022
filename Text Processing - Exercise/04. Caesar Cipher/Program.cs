using System;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);


            for (int h = 0; h < words.Length; h++)
            {
                char[] chars = words[h].ToCharArray();

                for (int i = 0; i < chars.Length; i++)
                {
                    int charNum = chars[i] + 3;
                    chars[i] = Convert.ToChar(charNum);
                }

                words[h] = new string(chars);
            }

            Console.WriteLine(String.Join("#", words));
        }
    }
}
