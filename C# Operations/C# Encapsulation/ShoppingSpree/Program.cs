using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    public class Program
    {
        //Create two classes: Person and Product
        //Each person should have a name, money, and a bag of products.
        //Each product should have a name and a cost.The name cannot be an empty string. Money cannot be a negative number.

        //Create a program where each command corresponds to a person buying a product.
        //If the person can afford a product, add it to his bag.
        //If a person doesn’t have enough money, print an appropriate message.

        //Input
        //On the first two lines, you are given all people and all products (Format: Peter=11;George=4).
        //After all, purchases print every person in the order of appearance and all products that he has bought also in order of appearance.
        //If nothing was bought, print the name of the person followed by "Nothing bought". 
        //In case of invalid input (negative money Exception message: "Money cannot be negative") or an empty name(empty name Exception message: "Name cannot be empty") break the program with an appropriate message.

        static void Main(string[] args)
        {
            Dictionary<string, Person> peopleList = new Dictionary<string, Person>();
            Dictionary<string, Product> productList = new Dictionary<string, Product>();

            string[] people = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            string[] products = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            try
            {
                for (int i = 0; i < people.Length; i++)
                {
                    string[] token = people[i].Split("=");
                    string name = token[0];
                    int money = int.Parse(token[1]);

                    Person currPerson = new Person(name, money);
                    peopleList.Add(name, currPerson);
                }

                for (int i = 0; i < products.Length; i++)
                {
                    string[] token = products[i].Split("=");
                    string productName = token[0];
                    int price = int.Parse(token[1]);

                    Product currProduct = new Product(productName, price);
                    productList.Add(productName, currProduct);
                }

                string command;
                while ((command = Console.ReadLine()) != "END")
                {
                    string[] token = command.Split(" ");
                    string personName = token[0];
                    string productName = token[1];

                    int currBudget = peopleList[personName].Money;
                    int currPrice = productList[productName].Price;

                    if (currBudget - currPrice >= 0)
                    {
                        peopleList[personName].Money -= currPrice;
                        peopleList[personName].Products.Add(productList[productName]);
                        Console.WriteLine($"{personName} bought {productName}");
                    }
                    else
                    {
                        Console.WriteLine($"{personName} can't afford {productName}");
                    }
                }
            }
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
            }

            foreach (var person in peopleList.Values)
            {
                Console.WriteLine(person.ToString());
                person.ToString();
            }
        }
    }
}
