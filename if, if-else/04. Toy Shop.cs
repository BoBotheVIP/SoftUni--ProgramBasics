using System;

namespace homeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int doll = int.Parse(Console.ReadLine());   
            int bear = int.Parse(Console.ReadLine());
            int minion = int.Parse(Console.ReadLine());
            int truck = int.Parse(Console.ReadLine());

            double toysPrice = puzzle * 2.60 + doll * 3 + bear * 4.10 + minion * 8.20 + truck * 2;
            int toysNumber = puzzle + doll + bear + minion + truck;

            if ( toysNumber >= 50)
            {
                toysPrice -= toysPrice * 0.25;
            }
                toysPrice -= toysPrice * 0.10;
           
            if (toysPrice >= tripPrice)
            {
                Console.WriteLine($"Yes! {toysPrice - tripPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {tripPrice - toysPrice:f2} lv needed.");
            }
        }
    }
}
