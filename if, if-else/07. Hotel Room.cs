using System;

namespace HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mounth = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmnetPrice = 0;

            if (mounth == "May" || mounth == "October")
            {
                studioPrice = nights * 50;
                apartmnetPrice = nights * 65;

                if (nights > 14)
                {
                    studioPrice -= studioPrice * 0.3;
                    apartmnetPrice -= apartmnetPrice * 0.1;
                }
                else if (nights > 7)
                {
                    studioPrice -=  studioPrice * 0.05;
                }
            }
            else if (mounth == "June" || mounth == "September")
            {
                studioPrice = nights * 75.2;
                apartmnetPrice = nights * 68.7;


                if (nights > 14)
                {
                    studioPrice -=  studioPrice * 0.2;
                    apartmnetPrice -=  apartmnetPrice * 0.1;
                }
            }
            else
            {
                studioPrice = nights * 76;
                apartmnetPrice = nights * 77;


                if (nights > 14)
                {
                    apartmnetPrice -=  apartmnetPrice * 0.1;
                }
            }

            Console.WriteLine($"Apartment: {apartmnetPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}
