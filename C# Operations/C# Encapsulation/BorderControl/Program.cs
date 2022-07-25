using System;
using System.Collections.Generic;

namespace BorderControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //We create a Dictionary where we will store our objects.
            Dictionary<string, IIdentifier> subjects = new Dictionary<string, IIdentifier>();

            //We create a While loop and receive the input.
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                //We split the input so we can get the needed information.
                string[] token = input.Split(' ');

                if (token.Length == 3)
                {
                    string name = token[0];
                    int age = int.Parse(token[1]);
                    string id = token[2];

                    //We use IIdentifier interface to initiate an instance of Citizen which we store in our common Dictionary.
                    IIdentifier currCitizen = new Citizen(name, age, id);
                    subjects.Add(id, currCitizen);
                }

                if (token.Length == 2)
                {
                    string model = token[0];
                    string id = token[1];

                    //We use IIdentifier interface to initiate an instance of Robot which we store in our common Dictionary.
                    IIdentifier currRobot = new Robot(model, id);
                    subjects.Add(id, currRobot);
                }
       
            }
            
            string fakeIdNumber = Console.ReadLine();
            List<string> fakeIdFound = new List<string>();

            //We use our custom method to make the validations and print the results.
            CheckFakeIds(fakeIdNumber, fakeIdFound, subjects);
            PrintFakeIds(fakeIdFound);
        }

        //We create a custom method for printing the final results.
        static void CheckFakeIds(string fakeIdNumber, List<string> fakeIdFound, Dictionary<string, IIdentifier> subjects)
        {
            foreach (var subject in subjects)
            {
                string digitToCheck = subject.Key.Substring(subject.Key.Length - fakeIdNumber.Length); ;
                if (digitToCheck == fakeIdNumber)
                {
                    fakeIdFound.Add(subject.Key);
                    subjects.Remove(subject.Key);
                }
            }
        }        
        static void PrintFakeIds(List<string> fakeIdFound)
        {
            foreach (var fakeFound in fakeIdFound)
            {
                Console.WriteLine(fakeFound);
            }
        }
    }
}
