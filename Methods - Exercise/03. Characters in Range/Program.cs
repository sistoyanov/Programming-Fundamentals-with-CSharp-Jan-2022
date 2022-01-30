using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());

            Characters(a, b);
        }

        static void Characters(char a, char b)
        {
            int start = 0;
            int end = 0;

            if ((int)a > (int)b)
            {
                start = (int)b;
                end = (int)a;
            }
            else
            {
                start = (int)a;
                end = (int)b;
            }

            for (int i = start + 1; i < end; i++)
            {
                Console.Write((char)i + " ");
            }

        }
    }
}
