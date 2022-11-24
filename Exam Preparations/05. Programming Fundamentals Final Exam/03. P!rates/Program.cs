using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<City> cityList = new List<City>();

            while ((input = Console.ReadLine()) != "Sail")
            {
                string[] cityArg = input.Split("||", StringSplitOptions.RemoveEmptyEntries);
                string cityName = cityArg[0];
                int cityPolulation = int.Parse(cityArg[1]);
                int cityGold = int.Parse(cityArg[2]);

                if (cityList.Any(n => n.Name == cityName))
                {
                    City cityToIncrease = FindCity(cityList, cityName);
                    cityToIncrease.Population += cityPolulation;
                    cityToIncrease.Gold += cityGold;
                }
                else
                {
                    City newCity = new City(cityName, cityPolulation, cityGold);
                    cityList.Add(newCity);
                }
            }

            while ((input = Console.ReadLine()) != "End")
            {
                string[] commandArg = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string commandType = commandArg[0];
                string currentCity = commandArg[1];

                if (commandType == "Plunder")
                {
                    int peopleToPlunder = int.Parse(commandArg[2]);
                    int goldToPlunder = int.Parse(commandArg[3]);
                    City cityToPlunder = FindCity(cityList, currentCity);

                    cityToPlunder.Population -= peopleToPlunder;
                    cityToPlunder.Gold -= goldToPlunder;

                    Console.WriteLine($"{currentCity} plundered! {goldToPlunder} gold stolen, {peopleToPlunder} citizens killed.");

                    if(cityToPlunder.Population <= 0 || cityToPlunder.Gold <= 0)
                    {
                        cityList.Remove(cityToPlunder);
                        Console.WriteLine($"{currentCity} has been wiped off the map!");
                    }

                }
                else if (commandType == "Prosper")
                {
                    int goldToProsper = int.Parse(commandArg[2]);
                    City cityToProsper = FindCity(cityList, currentCity);

                    if (goldToProsper < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }
                    else
                    {
                        cityToProsper.Gold += goldToProsper;
                        Console.WriteLine($"{goldToProsper} gold added to the city treasury. {currentCity} now has {cityToProsper.Gold} gold.");
                    }
                }
            }

            if (cityList.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cityList.Count} wealthy settlements to go to:");
                foreach (City city in cityList)
                {
                    Console.WriteLine($"{city.Name} -> Population: {city.Population} citizens, Gold: {city.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }

        static City FindCity (List<City> cityList, string cityName)
        {
            City searchedCity = cityList.FirstOrDefault(n => n.Name == cityName);
            return searchedCity;
        }
    }

    class City
    {
        public City(string cityName, int cityPopulation, int cityGold)
        {
            this.Name = cityName;
            this.Population = cityPopulation;
            this.Gold = cityGold;
        }

        public string Name { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }
    }
}
