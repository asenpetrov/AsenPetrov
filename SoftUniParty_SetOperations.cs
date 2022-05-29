using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //There is a party.
            //Many guests are invited and there are two types of them: VIP and Regular.
            //When a guest comes, check if he/she exists in any of the two reservation lists.
            
            HashSet<string> vipSet = new HashSet<string>();
            HashSet<string> regularSet = new HashSet<string>();

            string currentReservation = Console.ReadLine();
            while (currentReservation != "PARTY" && currentReservation != "END")
            {
                //check if reservation is valid
                if (ReservationCheck(currentReservation))
                {
                    //check if guest is VIP or Regular
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
                    //Removing the guests from the guestlists once they arrive
                    vipSet.Remove(currentReservation);
                    regularSet.Remove(currentReservation);
                    currentReservation = Console.ReadLine();
                }

                //Printing the count of the total guests that did not attend
                //Printing the unique guests who did not attend
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
