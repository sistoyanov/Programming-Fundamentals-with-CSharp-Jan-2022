using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < count; i++)
            {
                string currentCommand = Console.ReadLine();
                string currentName = currentCommand.Split(' ')[0];

                if (currentCommand.Contains("is going!"))
                {
                    if (guests.Contains(currentName))
                    {
                        Console.WriteLine($"{currentName} is already in the list!");
                    }
                    else
                    {
                        guests.Add(currentName);
                    }
                    
                    
                }
                else if (currentCommand.Contains("is not going!"))
                {
                    if (guests.Contains(currentName))
                    {
                        guests.Remove(currentName);
                    }
                    else
                    {
                        Console.WriteLine($"{currentName} is not in the list!");
                    }
                }
            }

            foreach (var name in guests)
            {
                Console.WriteLine(name);
            }
        }
    }
}
