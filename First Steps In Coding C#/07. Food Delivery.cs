using System;

namespace HomeWork
{ 
     class Program
    {
        static void Main(string[] args)
        {
            double ChickenNumber = double.Parse(Console.ReadLine());
            double FishNumber = double.Parse(Console.ReadLine());
            double VegetarianNumber = double.Parse(Console.ReadLine());

            double ChickenPrice = ChickenNumber * 10.35;
            double FishPrice = FishNumber * 12.40;
            double VegetarianPrice = VegetarianNumber * 8.15;

            double TotalCost = ChickenPrice + FishPrice + VegetarianPrice;

            double Dessert = TotalCost * 0.2;

            Console.WriteLine(TotalCost + Dessert + 2.5);
            


        }
    }
}


