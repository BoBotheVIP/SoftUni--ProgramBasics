using System;

namespace homeWork
{
    class Program
    {

        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double clothesPrice = double.Parse(Console.ReadLine());

            double decorPrice = budget * 0.10;
            double priceForExtras = extras * clothesPrice;

            if ( extras > 150)
            {
                priceForExtras -= priceForExtras * 0.10;
            }

            double money = priceForExtras + decorPrice;
            double difference = budget - money;

           
            if(difference >= 0)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {difference:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(difference):f2} leva more.");
            }

        }         
    }
}
