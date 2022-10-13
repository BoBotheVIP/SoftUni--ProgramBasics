using System;

namespace Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {    

           
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double budgetSpend = 0;
            string vacantion = "";
            string destination = "";
            if (budget <= 100)
            {
                if (season == "summer") 
                {
                    budgetSpend =  budget * 0.3;
                    vacantion = "Camp";
                }
                else if(season == "winter")
                {
                    budgetSpend =  budget * 0.7;
                    vacantion = "Hotel";
                }
                destination = "Bulgaria";
            }
            else if(budget <= 1000) 
            {
                if (season == "summer")
                {
                    budgetSpend=  budget * 0.4;
                    vacantion = "Camp";
                }
                else if (season == "winter")
                {
                    budgetSpend =  budget * 0.8;
                    vacantion = "Hotel";
                }
                destination = "Balkans";
            }
            else 
            {
                budgetSpend =  budget * 0.9;
                vacantion = "Hotel";
                destination = "Europe";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{vacantion} - {budgetSpend:f2}");

        }
    }
}
