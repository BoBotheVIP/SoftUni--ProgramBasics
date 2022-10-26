using System;

namespace VetParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double totalFee = 0;
            for(int day = 1; day <= days; day++)
            {
                double dailyFee = 0;

                //For each day
                for(int hour = 1; hour <= hours; hour++)
                {
                    //For each hour -> Tax
                    if (day % 2 == 0 && hour % 2 != 0)
                    {
                        dailyFee += 2.5;

                    }
                    else if (day % 2 != 0 && hour % 2 == 0)
                    {
                        dailyFee += 1.25;
                    }
                    else
                    {
                        dailyFee += 1;
                    }
                }
                 //Here at the end of the day we have daily fee, we need to pay
                 totalFee += dailyFee;
                 Console.WriteLine($"Day: {day} - {dailyFee:f2} leva");
            }
            Console.WriteLine($"Total: {totalFee:f2} leva");
        }
    }
}
