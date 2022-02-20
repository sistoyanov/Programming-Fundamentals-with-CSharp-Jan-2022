using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Space_Travel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> route = Console.ReadLine()
                .Split("||", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int fuel = int.Parse(Console.ReadLine());
            int ammunition = int.Parse(Console.ReadLine());

            foreach (var item in route)
            {
                string[] commandArg = item.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = commandArg[0];

                if (command == "Travel")
                {
                    int travelDistance = int.Parse(commandArg[1]);
         
                    if (fuel >= travelDistance)
                    {
                        fuel -= travelDistance;
                        Console.WriteLine($"The spaceship travelled {travelDistance} light-years.");
                    }
                    else
                    {
                        Console.WriteLine("Mission failed.");
                        return;
                    }
                }
                else if (command == "Enemy")
                {
                    int enemyArmour = int.Parse(commandArg[1]);

                    if (ammunition >= enemyArmour)
                    {
                        ammunition -= enemyArmour;
                        Console.WriteLine($"An enemy with {enemyArmour} armour is defeated.");
                    }
                    else
                    {
                        int fuelNeeded = enemyArmour * 2;

                        if (fuelNeeded <= fuel)
                        {
                            fuel -= fuelNeeded;
                            Console.WriteLine($"An enemy with {enemyArmour} armour is outmaneuvered.");
                        }
                        else
                        {
                            Console.WriteLine("Mission failed.");
                            return;
                        }
                    }
                }
                else if (command == "Repair")
                {
                    int currentNumber = int.Parse(commandArg[1]);

                    fuel += currentNumber;
                    ammunition += (currentNumber * 2);

                    Console.WriteLine($"Ammunitions added: {currentNumber * 2}.");
                    Console.WriteLine($"Fuel added: {currentNumber}.");
                }
                else if (command == "Titan")
                {
                    Console.WriteLine("You have reached Titan, all passengers are safe.");
                    return;
                }

            }
        }
    }
}
