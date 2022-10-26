using System;

namespace MovieProfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            string movieName = Console.ReadLine();
            int daysCount      =  int.Parse(Console.ReadLine());    
            int ticketsPerDay  =  int.Parse(Console.ReadLine());
            double ticketPrice =  double.Parse(Console.ReadLine());
            int cinemaPercent  =  int.Parse(Console.ReadLine());

            //action         

            double dayIncome   = ticketsPerDay * ticketPrice;
            double totalIncome = dayIncome * daysCount;
            double cinemaTax   = (cinemaPercent / 100.0 )* totalIncome;
            totalIncome       -= cinemaTax;

            //output
            Console.WriteLine($"The profit from the movie {movieName} is {totalIncome:f2} lv.");
        }
    }
}
