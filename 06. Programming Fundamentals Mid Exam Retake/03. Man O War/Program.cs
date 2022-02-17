using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Man_O_War
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine()
                .Split('>', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> warShip = Console.ReadLine()
                .Split('>', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxHealth = int.Parse(Console.ReadLine());
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Retire")
            {
                string[] commandArg = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = commandArg[0];

                if (command == "Fire")
                {
                    int attackIndex = int.Parse(commandArg[1]);
                    int warAttackDamage = int.Parse(commandArg[2]);

                    if (IsIndexValid(warShip, attackIndex))
                    {
                        warShip[attackIndex] -= warAttackDamage;

                        if (IsSectionSunken(warShip, attackIndex, warAttackDamage))
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Defend")
                {
                    int startIndex = int.Parse(commandArg[1]);
                    int endIndex = int.Parse(commandArg[2]);
                    int pirateAttackdamage = int.Parse(commandArg[3]);

                    if (IsIndexValid(pirateShip,startIndex) && IsIndexValid(pirateShip,endIndex))
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShip[i] -= pirateAttackdamage;

                            if (IsSectionSunken(pirateShip, i, pirateAttackdamage))
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }

                }
                else if (command == "Repair")
                {
                    int repairIndex = int.Parse(commandArg[1]);
                    int repairHealt = int.Parse(commandArg[2]);

                    if (IsIndexValid(pirateShip, repairIndex))
                    {
                        pirateShip[repairIndex] += repairHealt;

                        if (pirateShip[repairIndex] > maxHealth)
                        {
                            pirateShip[repairIndex] = maxHealth;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Status")
                {
                    double repairLimit = maxHealth * 0.20;
                    int repairCounter = 0;

                    foreach (var item in pirateShip)
                    {
                        if (item < repairLimit)
                        {
                            repairCounter++;
                        }
                    }

                    Console.WriteLine($"{repairCounter} sections need repair.");
                }

            }

            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warShip.Sum()}");
        }

        static bool IsIndexValid (List<int> ship, int index)
        {
            if (index < 0 || index > ship.Count - 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static bool IsSectionSunken(List<int> ship, int index, int damage)
        {
            if (ship[index] <= 0)
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
