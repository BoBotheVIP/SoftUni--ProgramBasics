using System;

namespace Gymnastics
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string country=Console.ReadLine();
            string tool=Console.ReadLine();

            double grade = 0;
            if (tool == "ribbon")
            {
                //The tool is ribbon
                if(country == "Russia")
                {
                    grade = 9.1 + 9.4;
                }
                else if(country == "Bulgaria")
                {
                    grade = 9.6 + 9.4;
                }
                else if( country == "Italy")
                {
                    grade = 9.2 + 9.5;
                }

            }
            else if(tool == "hoop")
            {
                //The tool is hoop

                if( country == "Russia")
                {
                    grade = 9.3 + 9.8;
                }
                else if (country == "Bulgaria")
                {
                    grade = 9.55 + 9.75;
                }
                else if (country == "Italy")
                {
                    grade = 9.45 + 9.35;
                }
            }
            else if (tool == "rope")
            {
                //The tool is rope

                if (country == "Russia")
                {
                    grade = 9.6 + 9;
                }
                else if (country == "Bulgaria")
                {
                    grade = 9.5 + 9.4;
                }
                else if (country == "Italy")
                {
                    grade = 9.7 + 9.15;
                }
            }
            
            double pointsToMax=20-grade;                            // tochki koito ne im dostigat
            double precentsToMax = (pointsToMax / 20) * 100;        // % koito ne im dostiga

            Console.WriteLine($"The team of {country} get {grade:f3} on {tool}.");
            Console.WriteLine($"{precentsToMax:f2}%");


        }
    }
}
