using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string input = string.Empty;
            Dictionary<string, int> resourses = new Dictionary<string, int>();

            string currentResource = string.Empty;
            int currentQuantity = 0;

            while ((input = Console.ReadLine()) != "stop")
            {
                counter++;
                

                if (counter % 2 != 0)
                {
                    currentResource = input;

                    if (!resourses.ContainsKey(currentResource))
                    {
                        resourses.Add(currentResource, currentQuantity);
                    }
                    else
                    {
                        resourses[currentResource] += currentQuantity;
                        currentQuantity = 0;
                    }
                   
                }
                else
                {
                    currentQuantity = int.Parse(input);
                    resourses[currentResource] += currentQuantity;
                    currentQuantity = 0;
                }
            }

            foreach (var resource in resourses)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
