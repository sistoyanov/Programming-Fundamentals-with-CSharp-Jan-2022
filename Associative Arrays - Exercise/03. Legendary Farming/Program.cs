using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>()
            {
                {"shards", 0},
                {"motes", 0},
                {"fragments", 0},
            };

            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();
            bool isMaterilaCrafted = false;

            while (!isMaterilaCrafted)
            {
                string[] inputArg = Console.ReadLine()
                    .ToLower()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int i = 0; i < inputArg.Length; i += 2)
                {
                    int currentQty = int.Parse(inputArg[i]);
                    string currentMaterial = inputArg[i + 1];

                    if (keyMaterials.ContainsKey(currentMaterial))
                    {
                        string craftedMaterial = AddKeyMaterial(keyMaterials, currentQty, currentMaterial);

                        if (!String.IsNullOrEmpty(craftedMaterial))
                        {
                            Console.WriteLine($"{craftedMaterial} obtained!");
                            isMaterilaCrafted = true;
                            break;
                        }
                    }
                    else
                    {
                        AddJunkMaterial(junkMaterials, currentQty, currentMaterial);
                    }
                }
            }

            PrintMaterials(keyMaterials);
            PrintMaterials(junkMaterials);

            static string AddKeyMaterial(Dictionary<string, int> keyMaterials, int currentQty, string currentMaterial)
            {
                string output = string.Empty;
                const int CRAFTVALUE = 250;
                
                if (currentMaterial == "shards")
                { 
                    keyMaterials[currentMaterial] += currentQty;

                    if (keyMaterials[currentMaterial] >= CRAFTVALUE)
                    {
                        output = "Shadowmourne";
                        keyMaterials[currentMaterial] -= 250;
                    }
                }
                else if (currentMaterial == "fragments")
                {
                    keyMaterials[currentMaterial] += currentQty;

                    if (keyMaterials[currentMaterial] >= CRAFTVALUE)
                    {
                        output = "Valanyr";
                        keyMaterials[currentMaterial] -= 250;
                    }
                }
                else if (currentMaterial == "motes")
                {
                    keyMaterials[currentMaterial] += currentQty;

                    if (keyMaterials[currentMaterial] >= CRAFTVALUE)
                    {
                        output = "Dragonwrath";
                        keyMaterials[currentMaterial] -= 250;
                    }
                }

                return output;
            }

            static void AddJunkMaterial(Dictionary<string, int> junkMaterials, int currentQty, string currentMaterial)
            {
                if (!junkMaterials.ContainsKey(currentMaterial))
                {
                    junkMaterials.Add(currentMaterial, 0);
                }

                junkMaterials[currentMaterial] += currentQty;
            }

            static void PrintMaterials(Dictionary<string, int> materialsCollection)
            {
                foreach (var kvp in materialsCollection)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                }
            }
        }
    }
}
