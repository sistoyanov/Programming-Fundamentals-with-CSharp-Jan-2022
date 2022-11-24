using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Need_for_Speed_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < count; i++)
            {
                string[] carDetails = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                string carName = carDetails[0];
                int carMileage = int.Parse(carDetails[1]);
                int carFuel = int.Parse(carDetails[2]);

                if (!cars.Any(n => n.Name == carName))
                {
                    Car newCar = new Car(carName, carMileage, carFuel);
                    cars.Add(newCar);
                }
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] commandArg = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = commandArg[0];
                string currentCarName = commandArg[1];

                if (currentCommand == "Drive")
                {
                    int distanceToDrive = int.Parse(commandArg[2]);
                    int fuelNeeded = int.Parse(commandArg[3]);
                    Car carToDrive = FindCar(cars, currentCarName);

                    if(fuelNeeded <= carToDrive.Fuel)
                    {
                        carToDrive.Mileage += distanceToDrive;
                        carToDrive.Fuel -= fuelNeeded;

                        Console.WriteLine($"{currentCarName} driven for {distanceToDrive} kilometers. {fuelNeeded} liters of fuel consumed.");

                        if (carToDrive.Mileage >= 100000)
                        {
                            cars.Remove(carToDrive);
                            Console.WriteLine($"Time to sell the {currentCarName}!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                        continue;
                    }
                }
                else if (currentCommand == "Refuel")
                {
                    int fuelToRefil = int.Parse(commandArg[2]);
                    Car carToRefil = FindCar(cars, currentCarName);
                    int currentFuel = carToRefil.Fuel;
                    int refiledFuel = fuelToRefil;
                    carToRefil.Fuel += fuelToRefil;

                    if(carToRefil.Fuel > 75 )
                    {
                        carToRefil.Fuel = 75;
                        refiledFuel = 75 - currentFuel;
                    }

                    Console.WriteLine($"{currentCarName} refueled with {refiledFuel} liters");

                }
                else if (currentCommand == "Revert")
                {
                    int kilometers = int.Parse(commandArg[2]);
                    Car carToRevert = FindCar(cars, currentCarName);
                    carToRevert.Mileage -= kilometers;

                    Console.WriteLine($"{currentCarName} mileage decreased by {kilometers} kilometers");
                    
                    if(carToRevert.Mileage < 10000)
                    {
                        carToRevert.Mileage = 10000;
                    }

                }

            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Name} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
            }
        }

        static Car FindCar (List<Car> cars, string currentCarName)
        {
            Car searchedCar = cars.FirstOrDefault(cars => cars.Name == currentCarName);
            return searchedCar;
        }
    }

    class Car
    {
        public Car(string carName, int carMileage, int carFuel)
        {
            this.Name = carName;
            this.Mileage = carMileage;
            this.Fuel = carFuel;
        }

        public string Name { get; set; }
        public int Mileage { get; set; }
        public int Fuel { get; set; }
    }
}
