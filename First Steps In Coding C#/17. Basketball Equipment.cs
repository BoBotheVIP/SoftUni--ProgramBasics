using System;

namespace HomeWork
{ 
     class Program
    {
        static void Main(string[] args)
        {
            int YearPrice = int.Parse(Console.ReadLine());
            
            double ShoesPrice = YearPrice - 0.4 * YearPrice;

            double ClothesPrice = ShoesPrice - 0.2 * ShoesPrice;

            double Ball = ClothesPrice * 0.25;

            double Accessories = Ball * 0.2;

            Console.WriteLine(YearPrice + ShoesPrice + ClothesPrice + Ball + Accessories);  
        }
    }
}


