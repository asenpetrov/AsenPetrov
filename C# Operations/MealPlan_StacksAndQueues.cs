using System;
using System.Linq;
using System.Collections.Generic;

namespace ExamPreparationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that helps John in calculating his calories intake, by predefined meals.
            //You will be given two lines of input.
            //The first line will be an array of strings, separated by a single space, representing meals that John can eat.
            //The second line will be an array of integers, separated by a single space, representing the maximum calories intake per day.

            //We create a dictionary with the default calories for each meal.

            //Start calculating calories as follows: take the first meal's calories and the last element in the sequence of calorie intake for a day.
            //Each time John eats a meal, the calories intake for the current day should be decreased by the calories of the given meal, and the current meal should be removed from the collection.
            //When the calories intake for the given day goes to zero, remove them from the collection, and continue to the next day.
            //If the calories for the given day go below zero, take as many calories as possible from the meal, so the current daily calories intake reaches zero.
            //The rest of the meal's calories should be subtracted from the next day in the calorie intake sequence.
            //For more clarification, check the provided examples.
            //The program stops when there are no more meals to be eaten, or there are no more daily calories to be calculated.

            Dictionary<string, int> mealBook = new Dictionary<string, int>()
            {
                {"salad", 350 },
                {"soup", 490 },
                {"pasta", 680 },
                {"steak", 790 },
            };

            //We create a Queue for the input meals.
            int mealCounter = 0;
            string[] mealsRaw = Console.ReadLine().Split(' ');
            Queue<string> meals = new Queue<string>();
            for (int i = 0; i < mealsRaw.Length; i++)
            {
                meals.Enqueue(mealsRaw[i]);
            }

            //We create a Stack for the daily calories.
            int[] caloriesRaw = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> daysCalories = new Stack<int>();
            for (int i = 0; i < caloriesRaw.Length; i++)
            {
                daysCalories.Push(caloriesRaw[i]);
            }

            //We innitiate a loop for meals and calories interaction.
            while (meals.Count > 0 || daysCalories.Count > 0)
            {
                if (meals.Count == 0)
                {
                    break;
                }

                if (daysCalories.Count == 0)
                {
                    break;
                }

                string currentMeal = meals.Peek();
                int currentDay = daysCalories.Peek();
                if (mealBook[currentMeal] <= currentDay)
                {
                    int dayToManipulate = daysCalories.Pop();
                    dayToManipulate -= mealBook[currentMeal];
                    daysCalories.Push(dayToManipulate);
                    if (dayToManipulate == 0)
                    {
                        daysCalories.Pop();

                    }
                    meals.Dequeue();
                    mealCounter++;
                    if (meals.Count == 0)
                    {
                        break;
                    }
                    if (daysCalories.Count == 0)
                    {
                        break;
                    }

                }

                else if (mealBook[currentMeal] > currentDay)
                {
                    int difference = mealBook[currentMeal] - currentDay;
                    daysCalories.Pop();
                    if (daysCalories.Count > 0)
                    {
                        currentDay = daysCalories.Pop();
                        currentDay -= difference;
                        daysCalories.Push(currentDay);
                        if (currentDay == 0)
                        {
                            daysCalories.Pop();
                        }
                        meals.Dequeue();
                        mealCounter++;
                        if (meals.Count == 0)
                        {
                            break;
                        }
                        if (daysCalories.Count == 0)
                        {
                            break;
                        }

                    }
                    else
                    {
                        meals.Dequeue();
                        mealCounter++;
                        break;
                    }

                }
            }
            Print(meals, daysCalories, mealCounter);
            
        }
        //We create a method for Printing the output.
        static void Print(Queue<string> meals, Stack<int> daysCalories, int mealCounter)
        {
            if (meals.Count == 0)
            {
                Console.WriteLine($"John had {mealCounter} meals.");
                Console.Write($"For the next few days, he can eat ");
                Console.Write(String.Join(", ", daysCalories));

                //foreach (var day in daysCalories)
                //{
                //    Console.Write(day + ", ");
                //}
                Console.WriteLine($" calories.");
            }
            else
            {
                Console.WriteLine($"John ate enough, he had {mealCounter} meals.");
                Console.Write("Meals left: ");
                Console.Write(String.Join(", ", meals));
                Console.WriteLine(".");
            }
        }
    }
}
