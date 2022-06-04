using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Receiving the start and end numbers from the console

            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int start = input[0];
            int end = input[1];

            List<int> numbers = new List<int>();

            //Creating a predicate to check each number

            Predicate<int> ifEven = number => number % 2 == 0;
            for (int i = start; i <= end; i++)
            {
                numbers.Add(i);
            }

            //command for which type to check
            string type = Console.ReadLine();

            if (type == "even")
            {

                foreach (var number in numbers)
                {
                    if (ifEven(number))
                    {
                        Console.Write($"{number} ");
                    }
                }
            }

            else if (type == "odd")
            {
                foreach (var number in numbers)
                {
                    if (!ifEven(number))
                    {
                        Console.Write($"{number} ");
                    }
                }
            }

            Console.WriteLine();
        }

    }
}
