using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = string.Empty;
            Catalog catalogObject = new Catalog(); 

            while ((input = Console.ReadLine()) != "end")
            {
                string[] commandArg = input.Split("/", StringSplitOptions.RemoveEmptyEntries);
                
                string type = commandArg[0];
                string brand = commandArg[1];
                string model = commandArg[2];
                double weighOrHorsePower = double.Parse(commandArg[3]);

                if (type == "Truck")
                {
                    Truck currentTruck = new Truck(brand, model, weighOrHorsePower);
                    catalogObject.Trucks.Add(currentTruck);
                }
                else if (type == "Car")
                {
                    Car currentCar = new Car(brand, model, weighOrHorsePower);
                    catalogObject.Cars.Add(currentCar);
                }
            }

            List<Car> orederedCars = catalogObject.Cars.OrderBy(car => car.Brand).ToList();
            List<Truck> orederedTruks = catalogObject.Trucks.OrderBy(truck => truck.Brand).ToList();

            if (orederedCars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in orederedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
                
            }

            if (orederedTruks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in orederedTruks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }

        }
    }

    class Truck
    {
        public Truck(string brand, string model, double weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        } 
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }  

    }

    class Car
    {
        public Car(string brand, string model, double horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double HorsePower { get; set; }
    }

    class Catalog
    {
        public Catalog()
        {
            Trucks = new List<Truck>();
            Cars = new List<Car>();
        }
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
    }
}
