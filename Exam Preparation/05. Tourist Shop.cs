using System;

namespace TouristShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string productName;

            int cnt = 0;
            double totalPrice = 0;
            while((productName = Console.ReadLine()) != "Stop")
            {
                double productPrice = double.Parse(Console.ReadLine());   
                cnt++;

                if (cnt % 3 == 0) //delenie na 3 s ostatuk 0
                {
                    productPrice /= 2;
                }

                totalPrice += productPrice;
                if(totalPrice > budget)
                {  
                    //Not enough money
                    break;
                }
            }
            if (totalPrice > budget)
            {
                //I do not have money for this product
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine("You don't have enough money!");
                Console.WriteLine($"You need {moneyNeeded:f2} leva!");             
            }
            else
            {
                //cnt broi zakupeni produkti
                Console.WriteLine($"You bought {cnt} products for {totalPrice:f2} leva.");
            }
           
        }
    }
}
