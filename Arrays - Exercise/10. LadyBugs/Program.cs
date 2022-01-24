using System;
using System.Linq;

namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int filedSize = int.Parse(Console.ReadLine());
            int[] field = new int[filedSize];
            int[] initialIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //for (int i = 0; i < initialIndexes.Length; i++)
            //{
            //    for (int j = 0; j < filedSize; j++)
            //    {
            //        if (initialIndexes[i] == j)
            //        {
            //            field[j] = 1;
            //        }
            //    }
            //}

            for (int i = 0; i < initialIndexes.Length; i++)
            {
                int currentIndex = initialIndexes[i];

                if (currentIndex >= 0 && currentIndex < filedSize)
                {
                    field[currentIndex] = 1;
                }
            }

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] currentComand = input.Split();
                int ladyBugIndex = int.Parse(currentComand[0]);
                string ladyBugDirection = currentComand[1];
                int ladyBugFlyLength = int.Parse(currentComand[2]);
                int ladyBugNewIndex = 0;

                if (ladyBugIndex < 0 || ladyBugIndex >= filedSize || field[ladyBugIndex] == 0)
                {
                    continue;
                }

                field[ladyBugIndex] = 0;

                if (ladyBugDirection == "right")
                {
                    ladyBugNewIndex = ladyBugIndex + ladyBugFlyLength;
                   
                    while (ladyBugNewIndex < field.Length)
                    {
                        if (field[ladyBugNewIndex] == 1)
                        {
                            ladyBugNewIndex += ladyBugFlyLength;
                            continue;
                        }

                        field[ladyBugNewIndex] = 1;
                        break;
                    }
                }
                else if (ladyBugDirection == "left")
                {
                    ladyBugNewIndex = ladyBugIndex - ladyBugFlyLength;
                    
                    while (ladyBugNewIndex >= 0)
                    {
                        if (field[ladyBugNewIndex] == 1)
                        {
                            ladyBugNewIndex -= ladyBugFlyLength;
                            continue;
                        }

                        field[ladyBugNewIndex] = 1;
                        break;
                    }
                }
            }

            Console.WriteLine(String.Join(" ", field));
        }
    }
}
