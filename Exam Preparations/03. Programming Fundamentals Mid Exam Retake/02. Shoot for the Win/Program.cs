using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int counter = 0;
            string input = string.Empty;
            
            while ((input = Console.ReadLine()) != "End")
            {
                int currentIndex = int.Parse(input);

                if (currentIndex < 0 || currentIndex > targets.Count - 1)
                {
                    continue;
                }

                if (targets[currentIndex] > -1)
                {
                    int targetValue = targets[currentIndex];
                    counter++;
                    targets[currentIndex] = -1;

                    for (int i = 0; i < targets.Count; i++)
                    {
                        if (targets[i] != -1)
                        {
                            if (targets[i] > targetValue)
                            {
                                targets[i] -= targetValue;
                            }
                            else
                            {
                                targets[i] += targetValue;
                            }
                        }
                    }
                }
                else
                {
                    continue;
                }

            }

            Console.WriteLine($"Shot targets: {counter} -> {String.Join(" ", targets)}");
        }
    }
}
