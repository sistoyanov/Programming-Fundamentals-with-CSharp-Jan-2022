using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> products = Console.ReadLine()
                .Split("!", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Go Shopping!")
            {
                string[] commandArg = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string currentCommand = commandArg[0];

                if (currentCommand == "Urgent")
                {
                    string item = commandArg[1];

                    if (products.Contains(item))
                    {
                        continue;
                    }
                    else
                    {
                        products.Insert(0, item);
                    }
                }
                else if (currentCommand == "Unnecessary")
                {
                    string item = commandArg[1];

                    if (products.Contains(item))
                    {
                        products.Remove(item); // (x=> x == item) there can be more than one
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (currentCommand == "Correct")
                {
                    string oldItem = commandArg[1];
                    string newItem = commandArg[2];

                    if (products.Contains(oldItem))
                    {
                        int indexOfOldProduct = products.IndexOf(oldItem);
                        products.RemoveAt(indexOfOldProduct);
                        products.Insert(indexOfOldProduct, newItem);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (currentCommand == "Rearrange")
                {
                    string item = commandArg[1];

                    if (products.Contains(item))
                    {
                        products.Remove(item);
                        products.Add(item);
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", products));
            
        }
    }
}
