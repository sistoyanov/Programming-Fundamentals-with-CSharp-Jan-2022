using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Take_Skip_Rope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<int> numbers = new List<int>();
            List<char> chars = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                int currentInt;
                bool isInt = int.TryParse(input[i].ToString(), out currentInt);

                if (isInt)
                {
                    numbers.Add(currentInt);
                }
                else
                {
                    chars.Add(input[i]);
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }

            List<char> output = new List<char>();
            int totalSkiped = 0;

            for (int index = 0; index < skipList.Count; index++)
            {
                int charsToSkip = skipList[index];
                int charsToTake = takeList[index];

                output.AddRange(chars.Skip(totalSkiped).Take(charsToTake));
  
                totalSkiped += charsToSkip + charsToTake;
            }

            Console.WriteLine(string.Join("", output));
        }
    }
}
