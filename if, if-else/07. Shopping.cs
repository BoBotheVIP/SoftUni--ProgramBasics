using System;

namespace homeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
          double budget = double.Parse(Console.ReadLine());
          int GPU = int.Parse(Console.ReadLine());
          int CPU = int.Parse(Console.ReadLine());
          int RAM = int.Parse(Console.ReadLine());

            int GPUsum = GPU * 250;
            double CPUprice = GPUsum * 0.35;
            double CPUsum = CPU * CPUprice;
            double RAMprice = GPUsum * 0.1;
            double RAMsum = RAMprice * RAM;

            double totalCost = GPUsum + CPUsum + RAMsum;

            if(GPU > CPU)
            {
                totalCost -= totalCost * 0.15;
            }
            double difference = budget - totalCost;

            if(budget >= totalCost)
            {
              Console.WriteLine($"You have {difference:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(difference):f2} leva more!");
            }
        }
    }
}
