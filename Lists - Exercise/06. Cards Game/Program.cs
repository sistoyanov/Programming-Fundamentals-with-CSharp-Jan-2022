using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> second = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int minCount = Math.Min(first.Count, second.Count);

            //for (int i = 0; i < minCount; i++)
            //{
            //    if (first[i] > second[i])
            //    {
            //        first.Add(second[i]);
            //        first.Add(first[i]);
            //        first.RemoveAt(i);
            //        second.RemoveAt(i);
            //    }
            //    else if (first[0] < second[i])
            //    {
            //        second.Add(first[i]);
            //        second.Add(second[i]);
            //        second.RemoveAt(i);
            //        first.RemoveAt(i);
            //    }
            //    else
            //    {
            //        first.RemoveAt(i);
            //        second.RemoveAt(i);
            //    }

            //    i--;

            //    minCount = Math.Min(first.Count, second.Count);
            //}

            while (minCount > 0)
            {
                if (first[0] > second[0])
                {
                    first.Add(second[0]);
                    first.Add(first[0]);
                    first.RemoveAt(0);
                    second.RemoveAt(0);
                }
                else if (first[0] < second[0])
                {
                    second.Add(first[0]);
                    second.Add(second[0]);
                    second.RemoveAt(0);
                    first.RemoveAt(0);
                }
                else
                {
                    first.RemoveAt(0);
                    second.RemoveAt(0);
                }

                minCount = Math.Min(first.Count, second.Count);
            }

            int sum = first.Count > second.Count ? first.Sum() : second.Sum();
            Console.WriteLine(first.Count > second.Count ? $"First player wins! Sum: {sum}" : $"Second player wins! Sum: {sum}");
        }

    }
}
