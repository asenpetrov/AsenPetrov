using System;
using System.Collections.Generic;
using System.Linq;

namespace BlacksmithProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First, you will be given a sequence representing steel. Afterward, you will be given another sequence representing carbon.
            //You should start from the first steel and try to mix it with the last carbon.
            //If the sum of their values is equal to any of the swords in the table below you should forge the sword corresponding to the value and remove both the steel and the carbon.
            //Otherwise, remove only the steel, increase the value of the carbon by 5 and insert it back into the collection.You need to stop forging when you have no more steel or carbon left.

            //This is the dictionary for comparing the forged sword with the default ones (Note that the Key is the sum and the Value is the name of the sword - this is for easier reference later).
            Dictionary<int, string> swords = new Dictionary<int, string>()
            {
                { 70, "Gladius"},
                { 80, "Shamshir" },
                { 90, "Katana"},
                { 110, "Sabre"},
                { 150, "Broadsword"},

            };

            //We create a new dictionary for the forged swords.
            SortedDictionary<string, int> forgedSwords = new SortedDictionary<string, int>();
            int totalSwords = 0;

            //We create a Queue for the steel as it will be the easiest to manipulate in this case.
            int[] rawSteal = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> steel = new Queue<int>();
            for (int i = 0; i < rawSteal.Length; i++)
            {
                steel.Enqueue(rawSteal[i]);
            }

            //We create a Stack for the carbon as it will be the easiest to manipulate in this case.
            int[] rawCarbon = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> carbon = new Stack<int>();
            for (int i = 0; i < rawCarbon.Length; i++)
            {
                carbon.Push(rawCarbon[i]);
            }

            //We compare our results and add forged swords.
            while (true)
            {
                if (steel.Count == 0 || carbon.Count == 0)
                {
                    break;
                }
                int currentSteel = steel.Peek();
                int currentCarbon = carbon.Pop();
                int currentResult = currentCarbon + currentSteel;

                if (swords.ContainsKey(currentResult))
                {
                    if (forgedSwords.ContainsKey(swords[currentResult]))
                    {
                        forgedSwords[swords[currentResult]]++;
                        totalSwords++;
                    }
                    else
                    {
                        forgedSwords.Add(swords[currentResult], 1);
                        totalSwords++;
                    }
                    steel.Dequeue();
                }
                else
                {
                    steel.Dequeue();
                    carbon.Push(currentCarbon + 5);
                }


                if (steel.Count == 0 || carbon.Count == 0)
                {
                    break;
                }
            }
            //We call our method for printing
            Print(forgedSwords, totalSwords, steel, carbon);


        }
        static void Print(SortedDictionary<string, int> forgedSwords, int totalSwords, Queue<int> steel, Stack<int> carbon)
        {
            if (forgedSwords.Count > 0)
            {
                Console.WriteLine($"You have forged {totalSwords} swords.");
            }
            else
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }

            if (steel.Count == 0)
            {
                Console.WriteLine("Steel left: none");
            }
            else
            {
                Console.Write("Steel left: ");
                Console.Write(string.Join(", ", steel));
                Console.WriteLine();
            }

            if (carbon.Count == 0)
            {
                Console.WriteLine("Carbon left: none");
            }
            else
            {
                Console.Write("Carbon left: ");
                Console.Write(string.Join(", ", carbon));
                Console.WriteLine();
            }

            foreach (var sword in forgedSwords)
            {
                Console.WriteLine($"{sword.Key}: {sword.Value}");
            }
        }
    }
}
