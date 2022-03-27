using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Plant> plants = new List<Plant>();

            for (int i = 0; i < count; i++)
            {
                string[] plantDetails = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string plantName = plantDetails[0];
                int plantRarity = int.Parse(plantDetails[1]);

                if (!IsPlantExists(plants, plantName))
                {
                    Plant newPlant = new Plant(plantName, plantRarity);
                    plants.Add(newPlant);
                }
                else
                {
                    Plant currentPlant = FindPlant(plants, plantName);
                    currentPlant.Rarity = plantRarity;
                }
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Exhibition") 
            {
                string[] commandArg = command
                    .Split(new char[] { ':', '-' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => s.Trim())
                    .ToArray();

                string commandType = commandArg[0];
                string currentPlantName = commandArg[1];

                if (!IsPlantExists(plants, currentPlantName))
                {
                    Console.WriteLine("error");
                    continue;
                }

                if (commandType == "Rate")
                {

                    double ratingToAdd = double.Parse(commandArg[2]);
                    Plant plantToRate = FindPlant(plants, currentPlantName);
                    plantToRate.Rating.Add(ratingToAdd);
                }
                else if (commandType == "Update")
                {

                    int rarityToUpdate = int.Parse(commandArg[2]);
                    Plant plantToUpdate = FindPlant(plants, currentPlantName);
                    plantToUpdate.Rarity = rarityToUpdate;
                }
                else if (commandType == "Reset")
                {
                    
                    Plant plantToReset = FindPlant(plants, currentPlantName);
                    plantToReset.Rating.Clear();
                }
            }

            Console.WriteLine("Plants for the exhibition:");

            foreach (Plant plant in plants)
            {
                double avarageRating = 0;
                
                if (plant.Rating.Count > 0)
                {
                    avarageRating = plant.Rating.Average();
                }

                Console.WriteLine($" - {plant.Name}; Rarity: {plant.Rarity}; Rating: {avarageRating:f2}");
            }
        }

        static bool IsPlantExists (List<Plant> plants, string plantName)
        {
            return plants.Any(n => n.Name == plantName);
        }

        static Plant FindPlant (List<Plant> plants, string plantName)
        {
            Plant searchedPlant = plants.FirstOrDefault(n => n.Name == plantName);
            return searchedPlant;
        }
    }

    class Plant
    {
        public Plant(string plantName, int plantRarity)
        {
            this.Name = plantName;
            this.Rarity = plantRarity;
            this.Rating = new List<double>();
        }

        public string Name { get; set; }
        public double Rarity { get; set; }
        public List<double> Rating { get; set; }

    }
}
