using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            char[] firstWord = input[0].ToCharArray();
            char[] secondWord = input[1].ToCharArray();

            int maxLenth = Math.Max(firstWord.Length, secondWord.Length);
            int totalSum = 0;

            for (int i = 0; i < maxLenth; i++)
            {

                if (i < firstWord.Length && i < secondWord.Length)
                {
                    totalSum += firstWord[i] * secondWord[i];
                }
                else if (i < firstWord.Length && i >= secondWord.Length)
                {
                    totalSum += firstWord[i];
                }
                else if (i >= firstWord.Length && i < secondWord.Length)
                {
                    totalSum += secondWord[i];
                }

            }

            Console.WriteLine(totalSum);

        }
    }
}
