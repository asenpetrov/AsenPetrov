using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            // Problem description:

            // Create a program that keeps track of cars and their fuel and supports methods for moving the cars.Define a class Car. Each Car has the following properties:
            //•	string Model
            //•	double FuelAmount
            //•	double FuelConsumptionPerKilometer
            //•	double Travelled distance

            //A car's model is unique - there will never be 2 cars with the same model. On the first line of the input, you will receive a number N – the number of cars you need to track. On each of the next N lines, you will receive information about a car in the following format: 
            //"{model} {fuelAmount} {fuelConsumptionFor1km}"

            //All cars start at 0 kilometers traveled.After the N lines, until the command "End" is received, you will receive commands in the following format: 
            //"Drive {carModel} {amountOfKm}"
            //Implement a method in the Car class to calculate whether or not a car can move that distance.If it can, the car's fuel amount should be reduced by the amount of used fuel and its traveled distance should be increased by the number of the traveled kilometers. Otherwise, the car should not move (its fuel amount and the traveled distance should stay the same) and you should print on the console:
            //"Insufficient fuel for the drive"

            //After the "End" command is received, print each car and its current fuel amount and the traveled distance

            int n = int.Parse(Console.ReadLine());
            //We create a list to store our cars.
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] token = input.Split(' ');
                string model = token[0];
                double fuelAmount = double.Parse(token[1]);
                double fuelConsumption = double.Parse(token[2]);
                double travelledDistance = 0;

                //We create a new car and add it to the list.
                Car currentCar = new Car(model, fuelAmount, fuelConsumption, travelledDistance);
                cars.Add(currentCar);
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] token = command.Split(" ");
                string commandType = token[0];
                string carModel = token[1];
                double distanceToTravel = double.Parse(token[2]);

                //We find and check if the selected car can travel the given distance.
                Car carToDrive = cars.First(car => car.Model == carModel);
                carToDrive.Drive(distanceToTravel);

                command = Console.ReadLine();
            }

            //We print the fuel and distance travelled for each car.
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
