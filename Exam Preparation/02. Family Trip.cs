using System;

namespace FamilyTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nightCount = int.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());
            int additionalFeesPrecent = int.Parse(Console.ReadLine());

            if (nightCount > 7)
            {
                pricePerNight -= pricePerNight * 0.05;            //5%tovata otstupka
            }          
            double additionalFees = (additionalFeesPrecent / 100.0) * budget;
            double totalPrice = (pricePerNight * nightCount)+additionalFees;

            if (budget >= totalPrice)
            {
                double moneyLeft=budget-totalPrice;
                Console.WriteLine($"Ivanovi will be left with {moneyLeft:f2} leva after vacation.");
            }
            else
            {
                double moneyMoreNeeded = totalPrice-budget;
                Console.WriteLine($"{moneyMoreNeeded:f2} leva needed.");
            }
        }
    }
}
