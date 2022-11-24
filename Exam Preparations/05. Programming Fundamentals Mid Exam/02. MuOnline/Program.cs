using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;
            int counter = 0;

            List<string> dungeon = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (counter < dungeon.Count)
            {
                string[] commandArg = dungeon[counter].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string currentCommand = commandArg[0];

                counter++;

                if (currentCommand == "potion")
                {
                    int additionalHealth = int.Parse(commandArg[1]);

                    health += additionalHealth;

                    if (health > 100)
                    {
                        Console.WriteLine($"You healed for {100 - (health - additionalHealth)} hp.");
                        health = 100;
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {additionalHealth} hp.");
                    }

                    Console.WriteLine($"Current health: {health} hp.");
                    continue;
                }

                if (currentCommand == "chest")
                {
                    int additionalBitcoins = int.Parse(commandArg[1]);

                    Console.WriteLine($"You found {additionalBitcoins} bitcoins.");

                    bitcoins += additionalBitcoins;
                    continue;
                }

                int attackPower = int.Parse(commandArg[1]);
                health -= attackPower;

                if (health > 0)
                {
                    Console.WriteLine($"You slayed {currentCommand}.");
                }
                else
                {
                    Console.WriteLine($"You died! Killed by {currentCommand}.");
                    Console.WriteLine($"Best room: {counter}");
                    break;
                }
        
            }

            if (health > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
