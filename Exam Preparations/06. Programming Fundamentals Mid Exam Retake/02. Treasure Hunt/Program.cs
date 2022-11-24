using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Treasure_Hunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> loot = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Yohoho!")
            {
                List<string> commandArg = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                string currentCommand = commandArg[0];

                if (currentCommand == "Loot")
                {
                    List<string> itemToAdd = commandArg.GetRange(1, commandArg.Count - 1);

                    foreach (string item in itemToAdd)
                    {
                        if (!loot.Contains(item))
                        {
                            loot.Insert(0, item);
                        }
                    }

                }
                else if (currentCommand == "Drop")
                {
                    int itemIndex = int.Parse(commandArg[1]);

                    if (itemIndex >= 0 && itemIndex < loot.Count - 1)
                    {
                        string currentLoot = loot[itemIndex];

                        loot.RemoveAt(itemIndex);
                        loot.Add(currentLoot);
                    }
                }
                else if (currentCommand == "Steal")
                {
                    int count = int.Parse(commandArg[1]);
                    List<string> removedItems = new List<string>();

                    if (count >= loot.Count)
                    {
                        removedItems.AddRange(loot);
                        loot.Clear();
                    }
                    else
                    {
                        for (int i = 1; i <= count ; i++)
                        {
                            removedItems.Insert(0, loot.Last());
                            loot.Remove(loot.Last());
                        }
                    }

                    Console.WriteLine(String.Join(", ", removedItems));
                }

            }

            if (loot.Count <= 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                double itemsCountSum = 0;

                foreach (var item in loot)
                {
                    itemsCountSum += item.Length;
                }

                double averageSum = itemsCountSum / loot.Count;

                Console.WriteLine($"Average treasure gain: {averageSum:f2} pirate credits.");
            }
        }
    }
}
