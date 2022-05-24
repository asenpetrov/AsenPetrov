using System;
using System.Linq;
using System.Collections.Generic;
namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = (Console.ReadLine().Split(" ").Select(int.Parse).ToArray());
            int n = input[0];
            int s = input[1];
            int x = input[2];

            Stack<int> numbers = new Stack<int>();
            List<int> list = (Console.ReadLine().Split(" ").Select(int.Parse).ToList());

            for (int i = 0; i < n; i++)
            {
                numbers.Push(list[i]);
            }

            for (int i = 0; i < s; i++)
            {
                numbers.Pop();
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine(0);
            }  
            
            else
            {
                if (numbers.Contains(x))
                {
                    Console.WriteLine("true");
                }

                else
                {
                    Console.WriteLine(numbers.Min());
                }
            }

        }
    }
}
