using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Speed_Racing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string input = string.Empty;
            List<Car> cars = new List<Car>();

            for (int i = 0; i < count; i++)
            {
                input = Console.ReadLine();
                string[] carDetails = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string carName = carDetails[0];
                double carFuel = double.Parse(carDetails[1]);
                double carConsumption = double.Parse(carDetails[2]);

                Car newCar = new Car(carName, carFuel, carConsumption);
                cars.Add(newCar);
            }

            while ((input = Console.ReadLine()) != "End")
            {
                string[] commandArg = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentCarName = commandArg[1];
                double currentDistance = double.Parse(commandArg[2]);

                if (IsTravelPosible(cars, currentCarName, currentDistance))
                {
                    Car carDriven = cars.FirstOrDefault(n => n.Model == currentCarName);
                    carDriven.Fuel -= (carDriven.Consumption * currentDistance);
                    carDriven.Kilometers += currentDistance;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }

            foreach (Car item in cars)
            {
                Console.WriteLine($"{item.Model} {item.Fuel:f2} {item.Kilometers}");
            }
        }

        static bool IsTravelPosible(List<Car> cars, string currentCar, double currentDistance)
        {
            Car carToDrive = cars.FirstOrDefault(n => n.Model == currentCar);
            double neededFuel = carToDrive.Consumption * currentDistance;

            if (neededFuel <= carToDrive.Fuel)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Car
    {
        public Car(string model, double fuel, double consumption)
        {
            this.Model = model;
            this.Fuel = fuel;
            this.Consumption = consumption;
        }

        public string Model { get; set; }
        public double Fuel { get; set; }
        public double Consumption { get; set; }
        public double Kilometers { get; set; } = 0;

        
    }
}
