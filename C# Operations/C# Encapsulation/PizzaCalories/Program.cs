using System;

namespace PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //We receive the input from the console and create our Pizza, Dough and Topping/s
                string pizzaName = Console.ReadLine().Split(" ")[1];
                Pizza currentPizza = new Pizza (pizzaName);
                double caloriesPizza = 0;

                string[] doughInfo = Console.ReadLine().Split(" ");
                string doughType = doughInfo[1];
                string bakingTech = doughInfo[2];
                int doughWeight = int.Parse(doughInfo[3]);
                Dough currentDough = new Dough(doughType, bakingTech, doughWeight);

                caloriesPizza += currentDough.CalculateCalories();
                //currentPizza.TotalCalories += currentDough.TotalCalories(currentDough);

                string toppingInfo = Console.ReadLine();
                while (toppingInfo != "END")
                {
                    string[] token = toppingInfo.Split(" ");
                    string toppingType = token[1];
                    int toppingWeight = int.Parse(token[2]);

                    Topping currentTopping = new Topping(toppingType, toppingWeight);
                    currentPizza.Toppings.Add(currentTopping);
                    caloriesPizza += currentTopping.CalculateCalories();

                    toppingInfo = Console.ReadLine();
                }
                if (currentPizza.Toppings.Count>10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }

                Console.WriteLine($"{currentPizza.Name} - {caloriesPizza:f2} Calories.");
            }
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
            }
           
        }
    }
}
