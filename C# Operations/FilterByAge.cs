using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Filter_By_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Read and fill the list of unfiltered people
            List<Person> people = new List<Person>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split(", ");
                string name = tokens[0];
                int age = int.Parse(tokens[1]);

                Person currentPerson = new Person(name, age);
                people.Add(currentPerson);
            }

            //Read the condition
            string condition = Console.ReadLine();
            int ageBarrier = int.Parse(Console.ReadLine());
            string typeOfPrint = Console.ReadLine();

            //Filter all matching people
            Func<Person, bool> filter = PersonFilter(condition, ageBarrier);
            List<Person> matchingPeople = people.Where(filter).ToList();

            //Printing the final result
            PrintingFilteredPeople(matchingPeople, typeOfPrint);

        }

        static void PrintingFilteredPeople(List<Person> matchingPeople, string typeOfPrint)
        {
            if (typeOfPrint == "name")
            {
                for (int i = 0; i < matchingPeople.Count; i++)
                {
                    Console.WriteLine(matchingPeople[i].Name);
                }
            }
            else if (typeOfPrint == "age")
            {
                for (int i = 0; i < matchingPeople.Count; i++)
                {
                    Console.WriteLine(matchingPeople[i].Age);
                }
            }
            else if (typeOfPrint == "name age")
            {
                for (int i = 0; i < matchingPeople.Count; i++)
                {
                    Console.WriteLine($"{matchingPeople[i].Name} - {matchingPeople[i].Age}");
                }
            }
        }
        static Func<Person, bool> PersonFilter(string condition, int ageBarrier)
        {
            if (condition == "older")
            {
                return x => x.Age > ageBarrier;
            }

            if (condition == "younger")
            {
                return x => x.Age < ageBarrier;
            }

            return null;
        }

    }
    class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }

    }
}