using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = string.Empty;
            int movesCounter = 0;

            while ((input = Console.ReadLine()) != "end")
            {
                if (elements.Count <= 0)
                {
                    
                    continue;
                }

                int[] currentIndexes = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                movesCounter++;
                int firstIndex = currentIndexes[0];
                int secondIndex = currentIndexes[1];

                if (IsIndexIvalid(elements, firstIndex, secondIndex))
                {
                    int middleIndex = (elements.Count / 2);
                    string elementToAdd = $"-{movesCounter}a";

                    elements.Insert(middleIndex, elementToAdd);
                    elements.Insert(middleIndex + 1, elementToAdd);

                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    continue;
                }

                if (elements[firstIndex] == elements[secondIndex])
                {
                    string removedElement = elements[firstIndex];
                    
                    if (firstIndex < secondIndex)
                    {
                        elements.RemoveAt(firstIndex);
                        elements.RemoveAt(secondIndex - 1);
                    }
                    else
                    {
                        elements.RemoveAt(firstIndex);
                        elements.RemoveAt(secondIndex);
                    }

                    Console.WriteLine($"Congrats! You have found matching elements - {removedElement}!");
                }
                else
                {
                    Console.WriteLine("Try again!");
                }
                
            }

            if (elements.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", elements));
            }
            else
            {
                Console.WriteLine($"You have won in {movesCounter} turns!");
            }

            

        }

        static bool IsIndexIvalid(List<string> numbers, int firstIndex, int secondIndex)
        {
            if (firstIndex == secondIndex)
            {
                return true;
            }

            if (firstIndex < 0 || firstIndex > numbers.Count - 1)
            {
                return true;
            }

            if (secondIndex < 0 || secondIndex > numbers.Count - 1)
            {
                return true;
            }

            return false;
        }
    }
}
