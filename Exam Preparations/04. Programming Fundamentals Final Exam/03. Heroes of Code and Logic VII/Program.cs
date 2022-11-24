using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Hero> heros = new List<Hero>();

            for (int i = 0; i < count; i++)
            {
                string[] heroDetails = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = heroDetails[0];
                int hitPoints = int.Parse(heroDetails[1]);
                int manaPoints = int.Parse(heroDetails[2]);

                if (!heros.Any(n => n.Name == name))
                {
                    Hero newHero = new Hero(name, hitPoints, manaPoints);
                    heros.Add(newHero);
                }
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArg = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string commandType = commandArg[0];
                string currentHeroName = commandArg[1];

                if (commandType == "CastSpell")
                {
                    int manaPointsNeeded = int.Parse(commandArg[2]);
                    string spellName = commandArg[3];

                    Hero heroToCastSpell = FindHero(heros, currentHeroName);

                    if (heroToCastSpell.ManaPoints >= manaPointsNeeded)
                    {
                        heroToCastSpell.ManaPoints -= manaPointsNeeded;
                        Console.WriteLine($"{currentHeroName} has successfully cast {spellName} and now has {heroToCastSpell.ManaPoints} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{currentHeroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (commandType == "TakeDamage")
                {
                    int damage = int.Parse(commandArg[2]);
                    string attacker = commandArg[3];

                    Hero heroToTakeDamage = FindHero(heros, currentHeroName);
                    heroToTakeDamage.HitPoints -= damage;

                    if (heroToTakeDamage.HitPoints > 0)
                    {
                        Console.WriteLine($"{currentHeroName} was hit for {damage} HP by {attacker} and now has {heroToTakeDamage.HitPoints} HP left!");
                    }
                    else
                    {
                        heros.Remove(heroToTakeDamage);
                        Console.WriteLine($"{currentHeroName} has been killed by {attacker}!");
                    }
                }
                else if (commandType == "Recharge")
                {
                    int regarge = int.Parse(commandArg[2]);
                    Hero heroToRecharge = FindHero(heros, currentHeroName);

                    int currentMP = heroToRecharge.ManaPoints;
                    int rechargedAmount = regarge;

                    heroToRecharge.ManaPoints += regarge;
                    
                    if (heroToRecharge.ManaPoints > 200)
                    {
                        heroToRecharge.ManaPoints = 200;
                        rechargedAmount = 200 - currentMP;
                    }

                    Console.WriteLine($"{currentHeroName} recharged for {rechargedAmount} MP!");
                }
                else if (commandType == "Heal")
                {
                    int heal = int.Parse(commandArg[2]);
                    Hero heroToHeal = FindHero(heros, currentHeroName);

                    int currentHP = heroToHeal.HitPoints;
                    int healAmount = heal;

                    heroToHeal.HitPoints += heal;

                    if (heroToHeal.HitPoints > 100)
                    {
                        heroToHeal.HitPoints = 100;
                        healAmount = 100 - currentHP;
                    }

                    Console.WriteLine($"{currentHeroName} healed for {healAmount} HP!");
                }

            }

            foreach (Hero hero in heros)
            {
                Console.WriteLine(hero.Name);
                Console.WriteLine($"  HP: {hero.HitPoints}");
                Console.WriteLine($"  MP: {hero.ManaPoints}");
            }
        }

        static Hero FindHero (List<Hero> heros, string name)
        {
            Hero searchedHero = heros.FirstOrDefault(n => n.Name == name);
            return searchedHero;
        }
    }

    class Hero
    {
        public Hero(string name, int hitPoints, int manaPoints)
        {
            this.Name = name;
            this.HitPoints = hitPoints;
            this.ManaPoints = manaPoints;
        }

        public string Name { get; set; }
        public int HitPoints { get; set; }
        public int ManaPoints { get; set; }
    }
}
