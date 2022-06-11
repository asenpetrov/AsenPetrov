using System;
using System.Collections.Generic;
using System.Linq;
namespace CarSalesMan
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            //Problem description:

            //Define two classes Car and Engine. 
            //Start by defining a class Car that holds information about:
            //•	Model: a string property
            //•	Engine: a property holding the engine object
            //•	Weight: an int property, it is optional
            //•	Color: a string property, it is optional

            //Next, the Engine class has the following properties:
            //•	Model: a string property
            //•	Power: an int property
            //•	Displacement: an int property, it is optional
            //•	Efficiency: a string property, it is optional

            // 1.On the first line, you will read a number N, which will specify how many lines of engines you will receive. 
            //•	On each of the next N lines, you will receive information about an Engine in the following format: "{model} {power} {displacement} {efficiency}"

            //2.Next, you will receive a number M, which will specify how many lines of car you will receive. 
            //•	On each of the next M lines, you will receive information about a Car in the following format: "{model} {engine} {weight} {color}".

            //•	The "engine" will always be the model of an existing Engine.
            //•	When creating the object for a Car, you should keep a reference to the real engine in it, instead of just the engine's model. 

            //We create a dict and a list where we will store our data
            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
            List<Car> cars = new List<Car>();

            int numOfEngines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfEngines; i++)
            {
                //We add each engine to our engine list to use later.
                string input = Console.ReadLine();
                EngineEntries(engines, input);

            }
            int numOfCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfCars; i++)
            {
                //we add each of the cars to our list using the data we receive and the data we have in the engines dictionary.
                string input = Console.ReadLine();

                CarEntries(input, engines, cars);
            }

            //we print all the cars with all the information for each of them
            PrintCars(cars);

        }
        static void EngineEntries(Dictionary<string, Engine> engines, string input)
        {
            string[] token = input.Split(' ');
            string engineModel = token[0];
            int enginePower = int.Parse(token[1]);

            //We create an option for each input variety
            if (token.Length == 2)
            {
                //We create the new Engine with the data we have received and add it to our Dictionary
                Engine currentEngine = new Engine(engineModel, enginePower);
                engines.Add(engineModel, currentEngine);
            }

            else if (token.Length == 3)
            {
                if (char.IsDigit(token[2][0]))
                {
                    int dispacement = int.Parse(token[2]);
                    //We create the new Engine with the data we have received and add it to our Dictionary
                    Engine currentEngine = new Engine(engineModel, enginePower, dispacement);
                    engines.Add(engineModel, currentEngine);
                }

                else
                {
                    string effieciency = token[2];
                    //We create the new Engine with the data we have received and add it to our Dictionary
                    Engine currentEngine = new Engine(engineModel, enginePower, effieciency);
                    engines.Add(engineModel, currentEngine);
                }
            }

            else if (token.Length == 4)
            {
                int dispacement = int.Parse(token[2]);
                string effieciency = token[3];
                //We create the new Engine with the data we have received and add it to our Dictionary
                Engine currentEngine = new Engine(engineModel, enginePower, dispacement, effieciency);
                engines.Add(engineModel, currentEngine);
            }
        }
        static void CarEntries(string input, Dictionary<string, Engine> engines, List<Car> cars)
        {
            string[] tokenCar = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string carModel = tokenCar[0];
            string engineModel = tokenCar[1];
            //We create an option for each input variety

            Engine currentEngine = engines[engineModel];

            if (tokenCar.Length == 2)
            {
                //We create the new car with the data we have received and with the Engine from our Dictionary and add it to our list of Cars
                Car currentCar = new Car(carModel, currentEngine);
                cars.Add(currentCar);
            }

            else if (tokenCar.Length == 3)
            {
                if (char.IsDigit(tokenCar[2][0]))
                {
                    int carWeight = int.Parse(tokenCar[2]);
                    //We create the new car with the data we have received and with the Engine from our Dictionary and add it to our list of Cars
                    Car currentCar = new Car(carModel, currentEngine, carWeight);
                    cars.Add(currentCar);
                }

                else
                {
                    string color = tokenCar[2];
                    //We create the new car with the data we have received and with the Engine from our Dictionary and add it to our list of Cars
                    Car currentCar = new Car(carModel, currentEngine, color);
                    cars.Add(currentCar);
                }

            }
            else if (tokenCar.Length == 4)
            {
                int carWeight = int.Parse(tokenCar[2]);
                string color = tokenCar[3];
                //We create the new car with the data we have received and with the Engine from our Dictionary and add it to our list of Cars
                Car currentCar = new Car(carModel, currentEngine, carWeight, color);
                cars.Add(currentCar);
            }

        }
        static void PrintCars(List<Car> cars)
        {
            //We print each car with the specifics it has
            //Note: if some of the optional input is missing, we print "n/a"
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                if (car.Engine.Displacement == 0)
                {
                    Console.WriteLine($"    Displacement: n/a");
                }

                else
                {
                    Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                }

                if (car.Engine.Efficiency == null)
                {
                    Console.WriteLine("    Efficiency: n/a");
                }

                else
                {
                    Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                }

                if (car.Weight == 0)
                {
                    Console.WriteLine("  Weight: n/a");
                }

                else
                {
                    Console.WriteLine($"  Weight: {car.Weight}");
                }

                if (car.Color == null)
                {
                    Console.WriteLine("  Color: n/a");
                }

                else
                {
                    Console.WriteLine($"  Color: {car.Color}");
                }
            }
        }
    }
}
