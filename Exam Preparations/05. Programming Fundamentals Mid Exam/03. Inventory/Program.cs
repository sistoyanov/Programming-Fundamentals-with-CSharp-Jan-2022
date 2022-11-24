using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Craft!")
            {
                string[] commandArg = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string currentComand = commandArg[0];
                string currentItem = commandArg[1];

                if (currentComand == "Collect")
                {
                    if (IsItemExists(items, currentItem))
                    {
                        continue;
                    }
                    else
                    {
                        items.Add(currentItem);
                    }
                }
                else if (currentComand == "Drop")
                {
                    if (IsItemExists(items, currentItem))
                    {
                        items.Remove(currentItem);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (currentComand == "Combine Items")
                {
                    string[] currentItems = currentItem.Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string oldItem = currentItems[0];
                    string newItem = currentItems[1];

                    if (IsItemExists(items, oldItem))
                    {
                        int oldItemIndex = items.IndexOf(oldItem);
                        items.Insert(oldItemIndex + 1, newItem);
                    }
                    else
                    {
                        continue;
                    }

                }
                else if (currentComand == "Renew")
                {
                    if (IsItemExists(items, currentItem))
                    {
                        items.Add(currentItem);
                        items.Remove(currentItem);
                    }
                    else
                    {
                        continue;
                    }
                }

            }

            Console.WriteLine(String.Join(", ", items));
        }

        static bool IsItemExists(List<string> items, string currentItem)
        {
            if (items.Contains(currentItem))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
