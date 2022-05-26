using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipSet = new HashSet<string>();
            HashSet<string> regularSet = new HashSet<string>();

            string currentReservation = Console.ReadLine();
            while (currentReservation != "PARTY" && currentReservation != "END")
            {
                //check if reservation is valid
                if (ReservationCheck(currentReservation))
                {
                    if (ReservationType(currentReservation))
                    {
                        vipSet.Add(currentReservation);
                    }
                    else
                    {
                        regularSet.Add(currentReservation);
                    }

                }
                else
                {
                    currentReservation = Console.ReadLine();
                    continue;
                }
                currentReservation = Console.ReadLine();
            }
            if (currentReservation == "PARTY")
            {
                while (currentReservation != "END")
                {
                    vipSet.Remove(currentReservation);
                    regularSet.Remove(currentReservation);
                    currentReservation = Console.ReadLine();
                }
                int sumTotal = vipSet.Count + regularSet.Count;
                Console.WriteLine(sumTotal);
                foreach (var vipGuest in vipSet)
                {
                    Console.WriteLine(vipGuest);
                }
                foreach (var guest in regularSet)
                {
                    Console.WriteLine(guest);
                }
            }
        }
        static bool ReservationCheck(string currentReservation)
        {
            if (currentReservation.Length == 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool ReservationType(string currentReservation)
        {
            char[] currentReservationCheck = currentReservation.ToCharArray();
            char chToCheck = currentReservationCheck[0];
            if (char.IsDigit(chToCheck))
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
