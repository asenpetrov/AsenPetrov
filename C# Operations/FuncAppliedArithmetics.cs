using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //We read our numbers from the console.
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //We prepare our functions for each operation
            Func<List<int>, List<int>> add = list => list.Select(number => number += 1).ToList();
            Func<List<int>, List<int>> multiply = list => list.Select(number => number *= 2).ToList();
            Func<List<int>, List<int>> subtract = list => list.Select(number => number -= 1).ToList();

            //We prepare the operation type
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "add")
                {
                    numbers = add(numbers);
                }
                else if (command == "multiply")
                {
                    numbers = multiply(numbers);
                }
                else if (command == "subtract")
                {
                    numbers = subtract(numbers);
                }
                else if (command == "print")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                }
            }
        }
    }
}
