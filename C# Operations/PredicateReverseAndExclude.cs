using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reverses a collection and removes elements that are divisible by a given integer n. Use predicates/functions.

            //We read our numbers from the console and add them to a List<int>.
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            //We read our number that we will use later.
            int masterNum = int.Parse(Console.ReadLine());

            //We create our predicate to filter the specific numbers.
            Predicate<int> masterNumManipulator = number => number % masterNum != 0;

            //We reverese our List and use the Predicate to filter. Then we print the numbers.
            numbers.Reverse();
            foreach (int number in numbers)
            {
                if (masterNumManipulator(number))
                {
                    Console.Write($"{number} ");
                }
            }
            Console.WriteLine();
        }
    }
}
