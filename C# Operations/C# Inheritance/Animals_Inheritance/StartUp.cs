namespace Animals
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Problem description:
            //Create a hierarchy of Animals. Your program should have three different animals – Dog, Frog, and Cat.
            //Deeper in the hierarchy you should have two additional classes – Kitten and Tomcat. Kittens are female and Tomcats are male.
            //All types of animals should be able to produce some kind of sound - ProduceSound(). For example, the dog should be able to bark.
            //Your task is to model the hierarchy and test its functionality. Create an animal of each kind and make them all produce sound.
            //You will be given some lines of input.
            //Every two lines will represent an animal.On the first line will be the type of animal
            //and on the second – the name, the age, and the gender.
            //When the command "Beast!" is given, stop the input and print all the animals in the format shown below.


            //We create a list to store our animals
            List<Animal> animals = new List<Animal>();

            string input;

            while ((input = Console.ReadLine()) != "Beast!")
            {
                //We define the info from the input.
                string animalType = input;
                string[] animalInfo = Console.ReadLine().Split(" ");
                string animalName = animalInfo[0];
                int animalAge = int.Parse(animalInfo[1]);

                
                //We check if the input if valid in our custome Check method.
                if (!Check(animalName, animalAge))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                //We create an Animal == null which will be modified with the information we have.
                Animal animal = null;
                if (animalType == "Dog")
                {
                    string animalGender = animalInfo[2];
                    animal = new Dog(animalName, animalAge, animalGender);                   
                }
                else if (animalType == "Cat")
                {
                    string animalGender = animalInfo[2];
                    animal = new Cat(animalName, animalAge, animalGender); 
                }
                else if (animalType == "Frog")
                {
                    string animalGender = animalInfo[2];
                    animal = new Frog(animalName, animalAge, animalGender);
                }
                else if (animalType == "Kitten")
                {
                    animal = new Kitten(animalName, animalAge);
                }
                else if (animalType == "Tomcat")
                {
                    animal = new Tomcat(animalName, animalAge);
                }

                animals.Add(animal);
            }

            //We print each animal.
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }

        public static bool Check(string animalName, int animalAge)
        {
            if (animalName == " " || animalName == null || animalAge <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
    }
}
