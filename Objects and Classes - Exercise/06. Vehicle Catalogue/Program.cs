using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            int totalCarsHorsePowers = 0;
            int totalTrucksHorsePowers = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] vehicleDetails = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string vehicleType = vehicleDetails[0];
                string vehicleModel = vehicleDetails[1];
                string vehicleColor = vehicleDetails[2];
                int vehicleHorsePower = int.Parse(vehicleDetails[3]);

                if (vehicleType == "car")
                {
                    cars.Add(new Car(vehicleModel, vehicleColor, vehicleHorsePower));
                    totalCarsHorsePowers += vehicleHorsePower;
                }
                else if (vehicleType == "truck")
                {
                    trucks.Add(new Truck(vehicleModel, vehicleColor, vehicleHorsePower));
                    totalTrucksHorsePowers += vehicleHorsePower;
                }
            }

            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                string currentVehicle = input;

                if (cars.Any(c => c.Model == currentVehicle))
                {
                    Car currentCar = cars.FirstOrDefault(c => c.Model == currentVehicle);
                    Console.WriteLine(currentCar);
                }
                else if (trucks.Any(t => t.Model == currentVehicle))
                {
                    Truck currentTruck = trucks.FirstOrDefault(t => t.Model == currentVehicle);
                    Console.WriteLine(currentTruck);
                }
            }

            double averageCarHorsePowers = 0;
            double averageTruckHorsePowers = 0;

            if (cars.Count > 0)
            {
                averageCarHorsePowers = CalculateHorseAveragePower(totalCarsHorsePowers, cars.Count);
            }

            if (trucks.Count > 0)
            {
                averageTruckHorsePowers = CalculateHorseAveragePower(totalTrucksHorsePowers, trucks.Count);
            }

            Console.WriteLine($"Cars have average horsepower of: {averageCarHorsePowers:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTruckHorsePowers:f2}.");

        }

        static double CalculateHorseAveragePower(int horsePowers, int totalCount)
        {
            double sum = (double)horsePowers / (double)totalCount;
            return sum;
        }
    }

    class Car
    {
        public Car(string model, string color, int horsePower)
        {
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine("Type: Car");
            output.AppendLine($"Model: {this.Model}");
            output.AppendLine($"Color: {this.Color}");
            output.AppendLine($"Horsepower: {this.HorsePower}");
            return output.ToString().Trim(); 
        }
    }
    class Truck
    {
        public Truck(string model, string color, int horsePower)
        {
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }

        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine("Type: Truck");
            output.AppendLine($"Model: {this.Model}");
            output.AppendLine($"Color: {this.Color}");
            output.AppendLine($"Horsepower: {this.HorsePower}");
            return output.ToString().Trim();
        }
    }
}
