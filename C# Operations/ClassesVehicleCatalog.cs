using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Your task is to create a Vehicle catalog, which contains only Trucks and Cars.
            //Define a class Truck with the following properties: Brand, Model, and Weight.
            //Define a class Car with the following properties: Brand, Model, and Horse Power.
            //Define a class Catalog with the following properties: Collections of Trucks and Cars.
            //You must read the input until you receive the "end" command.It will be in following format: "{type}/{brand}/{model}/{horse power / weight}"
            //In the end, you have to print all of the vehicles ordered alphabetical by brand.

            //We define our classes
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            Catalog catalog = new Catalog(cars, trucks);

            //We read our command
            string command = Console.ReadLine();
            while (command != "end")
            {
                //"{type}/{brand}/{model}/{horse power / weight}"
                string[] token = command.Split("/").ToArray();
                string type = token[0];

                if (type == "Truck")
                {
                    string brand = token[1];
                    string model = token[2];
                    int weigth = int.Parse(token[3]);
                    Truck currentTruck = new Truck(brand, model, weigth);
                    trucks.Add(currentTruck);
                    catalog.TrucksInCatalog.Add(currentTruck);
                }

                else if (type == "Car")
                {
                    string brand = token[1];
                    string model = token[2];
                    int horsePower = int.Parse(token[3]);
                    Car currentCar = new Car(brand, model, horsePower);
                    cars.Add(currentCar);
                    catalog.CarsInCatalog.Add(currentCar);
                }

                command = Console.ReadLine();
            }

            //We print the cars (if any)
            if (cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in catalog.CarsInCatalog.OrderBy(car => car.Brand))
                {
                    //Audi: A3 - 110hp
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }

            //We print the trucks (if any)
            }
            if (trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in catalog.TrucksInCatalog.OrderBy(truck => truck.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }

        }
    }
    class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }

    }
    class Car
    {
        public Car(string brand, string model, int horsepower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsepower;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }

    }
    class Catalog
    {
        public Catalog(List<Car> cars, List<Truck> trucks)
        {
            this.CarsInCatalog = new List<Car>();
            this.TrucksInCatalog = new List<Truck>();

        }
        public List<Car> CarsInCatalog { get; set; }
        public List<Truck> TrucksInCatalog { get; set; }

    }
}
