using System;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //char[] volwels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            string volwels = "aeiouAEIOU";
            char[] chars = input.ToCharArray();
            int volwelsCount = VowelsCouter(volwels, chars);

            Console.WriteLine(volwelsCount);
        }

        static int VowelsCouter(string volwels, char[] chars)
        {
            int volwelsCount = 0;
            
            foreach (var item in chars)
            {
                if (volwels.Contains(item))
                {
                    volwelsCount++;
                }
            }

            return volwelsCount;
        }
    }
}
