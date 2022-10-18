using System;


namespace TennisRanklist

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eventsNum        =int.Parse(Console.ReadLine());
            int startingPoints   =int.Parse(Console.ReadLine());
            string stageReached;   
            int pointsAvr=0;
            int sumAllPounts= startingPoints;
            double counter=0;  

            for (int i = 0; i < eventsNum; i++)                    
            {
                stageReached = Console.ReadLine();
 

                if (stageReached == "W")
                {
                    sumAllPounts += 2000;
                    pointsAvr = pointsAvr + 2000;
                    counter++;
                }
                else if (stageReached == "F")
                {
                    sumAllPounts += 1200;
                    pointsAvr = pointsAvr + 1200;
                }
                else if (stageReached == "SF")
                {
                    sumAllPounts += 720;
                    pointsAvr = pointsAvr + 720;
                }
            }
            
            Console.WriteLine($"Final points: {sumAllPounts}");
            Console.WriteLine($"Average points: {pointsAvr/eventsNum}");
            Console.WriteLine($"{counter / eventsNum * 100:f2}%");
        }
    }
}

