using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //price of package pens

            double NumberPens = double.Parse(Console.ReadLine());
            double PenPack = 5.80;
            double PenPricePacks = NumberPens * PenPack;

            //price of package markers
             
            double NumberMarkers = double.Parse(Console.ReadLine());
            double MarkerPack = 7.20;
            double MarkerPricePacks = NumberMarkers * MarkerPack;

            //detergent 

            double NumberDetergents = double.Parse(Console.ReadLine());
            double Detergent = 1.20;
            double DetergentPrice = NumberDetergents * Detergent;

            //all materials price

            double AllMaterialPrice = PenPricePacks + MarkerPricePacks + DetergentPrice;

            //discount

            double Discount = double.Parse(Console.ReadLine());
            double DiscountProcent = Discount / 100;

            //price with discound

            Console.WriteLine(AllMaterialPrice - (AllMaterialPrice * DiscountProcent));



        }
        
    }
}







