using System;
using System.Collections.Generic;

namespace BirthdayCelebrations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //We create Dictionaries where we will store our objects.
            Dictionary<string, IIdentifier> subjects = new Dictionary<string, IIdentifier>();
            Dictionary<string, IBirthdayable> livingCreatures = new Dictionary<string, IBirthdayable>();

            //We create a While loop and receive the input.
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                //We split the input so we can get the needed information.
                string[] token = input.Split(' ');
                string type = token[0];

                if (type == "Citizen")
                {
                    string name = token[1];
                    int age = int.Parse(token[2]);
                    string id = token[3];
                    string birthdate = token[4];

                    //We use IBirthdayable interface to initiate an instance of Citizen which we store in the correct Dictionary.
                    IBirthdayable currCitizen = new Citizen(name, age, id, birthdate);
                    livingCreatures.Add(birthdate, currCitizen);
                }
                else if (type == "Robot")
                {
                    string model = token[1];
                    string id = token[2];

                    //We use IIdentifier interface to initiate an instance of Robot which we store in the correct Dictionary.
                    IIdentifier currRobot = new Robot(model, id);
                    subjects.Add(id, currRobot);
                }
                else if (type == "Pet")
                {
                    string name = token[1];
                    string birthDay = token[2];

                    //We use IBirthdayable interface to initiate an instance of Pet which we store in the correct Dictionary.
                    IBirthdayable currPet = new Pet(name, birthDay);
                    livingCreatures.Add(birthDay, currPet);
                }
                
            }

            string yearToCheck = Console.ReadLine();
            List<string> machedYears = new List<string>();

            //We use our custom method to make the validations and print the results.
            CheckMatches(yearToCheck, livingCreatures, machedYears);
            PrintMatches(machedYears);
        }

        static void CheckMatches(string yearToCheck, Dictionary<string, IBirthdayable> livingCreatures, List<string> machedYears)
        {
            foreach (var creature in livingCreatures)
            {
                string currentYear = creature.Key.Split("/")[2];
                if (currentYear == yearToCheck)
                {
                    machedYears.Add(creature.Key);
                }
            }
        }
        static void PrintMatches(List<string> machedYears)
        {
            foreach (var match in machedYears)
            {
                Console.WriteLine(match);
            }
        }

    }
}
