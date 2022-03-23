using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                             .Split(",", StringSplitOptions.RemoveEmptyEntries);
            
            for(int i = 0; i < input.Length; i++)
            {
                input[i] = input[i].Replace(" ",String.Empty);

            }

            //string regEx = @" *,{1} *"
            //string[] input = Regex.Split(Console.ReadLine(), regEx);

            List<Demon> demons = new List<Demon>();
            
            foreach (string demon in input)
            {
                string currentDemonName = demon;
                double currentDemonHealth = CalculateHealth(currentDemonName);
                double currentDemonDamage = CalculateDamage(currentDemonName);

                Demon newDemon = new Demon (currentDemonName, currentDemonHealth, currentDemonDamage);
                demons.Add(newDemon);
            }

            demons = demons.OrderBy(n => n.Name).ToList();

            foreach (Demon demon in demons)
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
            }
        }

        static double CalculateHealth (string currentDemonName)
        {
            string regExHealth = @"[^0-9\.\+\-\*\/]";
            MatchCollection healthMath = Regex.Matches(currentDemonName, regExHealth);
            double demonHealth = 0;
            
            foreach (Match character in healthMath)
            {
                demonHealth += Convert.ToChar(character.Value);
            }

            return demonHealth;
        }

        static double CalculateDamage (string currentDemonName)
        {
            string regExNumbers = @"-?\d+(\.\d+)?"; // working "((|-)\d+\.\d+|(|-)\d+)"  //working "(-?\d*)(\d+(\.\d+)?)"
            string regExSymbols = @"[\*\/]";
            double demonDamage = 0;

            MatchCollection numbersMatch = Regex.Matches(currentDemonName, regExNumbers);
            MatchCollection symbolsMatch = Regex.Matches(currentDemonName, regExSymbols);
                
            foreach (Match number in numbersMatch)
            {
                
               demonDamage += Convert.ToDouble(number.Value);

            }

            foreach (Match symbol in symbolsMatch)
            {
                if (symbol.Value == "*")
                {
                    demonDamage *= 2;
                }
                else if (symbol.Value == "/")
                {
                    demonDamage /= 2;
                }

            }

            return demonDamage;
        }
    }

    class Demon
    {
        public Demon(string name, double health, double damage)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
        }

        public string Name { get; set; }
        public double Health { get; set; }
        public double Damage { get; set; }
    }
}
