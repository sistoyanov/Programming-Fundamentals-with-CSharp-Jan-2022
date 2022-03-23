using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string pattern = @"@(?<name>[A-Za-z]+)[^\@\-\!\:\>]*?\:(\d+)[^\@\-\!\:\>]*?\!(?<type>[A|D]{1})\![^\@\-\!\:\>]*?\-\>(\d+)";
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < count; i++)
            {
                string encriptedMessage = Console.ReadLine();
                string decriptedMessage = DecriptMessage(encriptedMessage);

                Match match = Regex.Match(decriptedMessage, pattern);

                if (match.Success)
                {
                    string planetName = match.Groups["name"].Value;
                    string attackType = match.Groups["type"].Value;

                    if (attackType == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else if (attackType == "D")
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }

            attackedPlanets.Sort();
            destroyedPlanets.Sort();

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (string planet in attackedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (string planet in destroyedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }
        }

        static int GenerateDecriptionKey (string encriptedMessage)
        {
            string regex = @"[star]{1}";
            MatchCollection matches = Regex.Matches(encriptedMessage, regex, RegexOptions.IgnoreCase);
            return matches.Count;
        }

        static string DecriptMessage (string encriptedMessage)
        {
            int decriptionKey = GenerateDecriptionKey(encriptedMessage);
            StringBuilder decripted = new StringBuilder();

            foreach (char character in encriptedMessage)
            {
                decripted.Append(Convert.ToChar(character - decriptionKey));
            }

            return decripted.ToString();
        }
    }
}
