using System;

namespace PoolDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            double entranceFee = double.Parse(Console.ReadLine());
            double costOfSunLounger = double.Parse(Console.ReadLine());
            double costOfUmbrella = double.Parse(Console.ReadLine());

            double allEntranceFee = numOfPeople * entranceFee;
            double loungerPrice =Math.Ceiling(numOfPeople * 0.75) * costOfSunLounger;
            double umbrelaPrice = Math.Ceiling(numOfPeople * 0.5) * costOfUmbrella;

            double finalPrice = allEntranceFee  + loungerPrice+ umbrelaPrice;
            Console.WriteLine($"{finalPrice:f2} lv.");

        }
    }
}
