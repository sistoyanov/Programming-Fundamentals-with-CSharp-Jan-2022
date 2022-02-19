using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Mixed_up_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputOne = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> inputTwo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int length = 0;  //Math.Min(inputOne.Count, inputTwo.Count);
            bool isInputOneBigger = false;

            if (inputOne.Count > inputTwo.Count)
            {
                isInputOneBigger = true;
                length = inputTwo.Count;
            }
            else
            {
                length = inputOne.Count;
            }

            List<int> mixed = new List<int>();

            for (int i = 0; i < length; i++)
            {
                mixed.Add(inputOne[i]);
                mixed.Add(inputTwo[(inputTwo.Count - 1) - i]);
            }

            List<int> remainingNums = new List<int>();
            
            if (isInputOneBigger)
            {

                remainingNums.AddRange(inputOne.GetRange(inputOne.Count - 2, 2));
            }
            else
            {
                remainingNums.AddRange(inputTwo.GetRange(0, 2));
            }

            remainingNums.Sort();
            mixed.RemoveAll(x => x <= remainingNums[0]);
            mixed.RemoveAll(x => x >= remainingNums[1]);

            mixed.Sort();

            Console.WriteLine(String.Join(" ", mixed));
        }
    }
}
