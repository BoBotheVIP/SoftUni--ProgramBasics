using System;

namespace NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;

            switch (flower)
            {
                case  "Roses":
                    price = number * 5;  
                        break;
                case "Dahlias":
                    price = number * 3.80;
                    break;
                case "Tulips":
                    price = number * 2.80;
                    break;
                case "Narcissus":
                    price = number * 3;
                    break;
                case "Gladiolus":
                    price = number * 2.50;
                    break;
            }

            if (flower == "Roses" && number > 80)
            {
                price = price - price * 0.1;
            }
            else if (flower == "Dahlias" && number > 90)
            {
                price = price - price * 0.15;
            }
            else if (flower == "Tulips" && number > 80) 
            {
                price = price - price * 0.15;
            }
            else if(flower == "Narcissus" && number < 120)
            {
                price = price + price * 0.15;
            }
            else if (flower== "Gladiolus" && number < 80)
            {
                price = price + price * 0.2;
            }

            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {number} {flower} and {budget-price:f2} leva left.");
            }
            else if(budget < price)
            {
                Console.WriteLine($"Not enough money, you need {price - budget:f2} leva more.");
            }
        }
    }
}
