using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            //Problem description:

            //Create a program that tracks cars and their cargo.
            //Start by defining a class Car that holds information about:
            //•	Model: a string property
            //•	Engine: a class with two properties – speed and power,
            //•	Cargo: a class with two properties – type and weight 
            //•	Tires: a collection of exactly 4 tires.Each tire should have two properties: age and pressure.
            //Create a constructor that receives all of the information about the Car and creates and initializes the model and its inner components(engine, cargo and tires).

            //On the first line of input, you will receive a number N representing the number of cars you have. 

            //1.On the next N lines, you will receive information about each car in the format:
            //"{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType} {tire1Pressure} {tire1Age} {tire2Pressure} {tire2Age} {tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}"
            //•	The speed, power, weight and tire age are integers.
            //•	The tire pressure is a floating point number. 

            //2.Next, you will receive a single line with one of the following commands:  "fragile" or "flammable".

            //As an output, if the command is:
            //•	"fragile" - print all cars, whose cargo is "fragile" and have a pressure of a single tire < 1.
            //•	"flammable" - print all cars, whose cargo is "flammable" and have engine power > 250.

            //We create our list to the Cars.
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                //We split the input so we can use the information for each separate class.
                string input = Console.ReadLine();
                string[] token = input.Split(" ");
                string currentModel = token[0];
                int engineSpeed = int.Parse(token[1]);
                int enginePower = int.Parse(token[2]);
                int cargoWeight = int.Parse(token[3]);
                string cargoType = token[4];
                double tyrePressure1 = double.Parse(token[5]);
                int tyreAge1 = int.Parse(token[6]);
                double tyrePressure2 = double.Parse(token[7]);
                int tyreAge2 = int.Parse(token[8]);
                double tyrePressure3 = double.Parse(token[9]);
                int tyreAge3 = int.Parse(token[10]);
                double tyrePressure4 = double.Parse(token[11]);
                int tyreAge4 = int.Parse(token[12]);



                //We create the new Engine and Cargo with the data from the input.
                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoType, cargoWeight);

                //We split the information for the tyres.
                double[] tyresPressure = new double[]
                {
                    tyrePressure1,
                    tyrePressure2,
                    tyrePressure3,
                    tyrePressure4
                };
                int[] tyresAge = new int[]
                {
                    tyreAge1,
                    tyreAge2,
                    tyreAge3,
                    tyreAge4
                };
                //We create the Tyres with data we have received.
                List<Tyres> tyres = new List<Tyres>();
                for (int k = 0; k <= 3; k++)
                {
                    var tyre = new Tyres();
                    tyre.Pressure = tyresPressure[k];
                    tyre.TyreAge = tyresAge[k];
                    tyres.Add(tyre);

                }

                //The new car is created and added to our list.
                Car currentCar = new Car(currentModel, engine, cargo, tyres);
                cars.Add(currentCar);
            }

            //New lists are created so we can print the desired cars.
            List<Car> flammableCars = new List<Car>();
            List<Car> fragileCars = new List<Car>();
            string outputCommand = Console.ReadLine();
            if (outputCommand == "fragile")
            {

                foreach (var car in cars)
                {
                    if (car.Cargo.TypeCargo == "fragile")
                    {
                        foreach (var tyre in car.Tyres)
                        {
                            if (tyre.Pressure < 1)
                            {
                                fragileCars.Add(car);
                                break;
                            }

                        }
                    }
                }
                foreach (var car in fragileCars)
                {
                    //•	"fragile" - print all cars, whose cargo is "fragile" and have a pressure of a single tire < 1.

                    Console.WriteLine(car.Model);
                }
            }

            else if (outputCommand == "flammable")
            {
                foreach (var car in cars)
                {
                    if (car.Cargo.TypeCargo == "flammable")
                    {
                        if (car.Engine.Power > 250)
                        {
                            flammableCars.Add(car);
                        }
                    }
                }
                foreach (var car in flammableCars)
                {
                    Console.WriteLine(car.Model);
                    //•	"flammable" - print all cars, whose cargo is "flammable" and have engine power > 250.
                }
            }
        }
    }
}
