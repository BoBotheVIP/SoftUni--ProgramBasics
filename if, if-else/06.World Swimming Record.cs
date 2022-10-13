using System;

namespace homeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordSeconds = double.Parse(Console.ReadLine());
            double distanceMetres = double.Parse(Console.ReadLine());
            double timeSeconds = double.Parse(Console.ReadLine());

            double swimmingDistanceToSeconds = distanceMetres * timeSeconds;
            double waterResistance = Math.Floor(distanceMetres / 15) * 12.5;
            double totalTime = swimmingDistanceToSeconds + waterResistance;
            double difference = totalTime - recordSeconds;
           
            if(recordSeconds > totalTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {difference:f2} seconds slower.");
            }
        }
    }
}
