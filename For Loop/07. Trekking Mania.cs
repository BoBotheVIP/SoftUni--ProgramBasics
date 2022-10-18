using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupeNum = int.Parse(Console.ReadLine());
            int people;
            double total=0;

            double musala      = 0;  
            double monblan     = 0;
            double kilimanjaro = 0;
            double k2          = 0;
            double everest     = 0;


            for (int i = 0; i < groupeNum; i++)
            {
                people = int.Parse(Console.ReadLine());
                total += people;

                if (people <= 5)
                {
                    musala += people;
                }
                else if (people >= 6 && people <= 12)
                {
                    monblan += people;
                }
                else if(people >= 13 && people <= 25)
                {
                    kilimanjaro += people;
                }
                else if(people >= 26 && people <= 40)
                {
                    k2 += people;
                }
                else if (people >= 41)
                {
                    everest+=people;
                }
            }
            

            musala       =    musala        /total    * 100;  
            monblan      =    monblan       /total    * 100;
            kilimanjaro  =    kilimanjaro   /total    * 100;
            k2           =    k2            /total    * 100;
            everest      =    everest       /total    * 100;

             Console.WriteLine ($"{musala:f2}%");
             Console.WriteLine ($"{monblan:f2}%");
             Console.WriteLine ($"{kilimanjaro:f2}%");
             Console.WriteLine ($"{k2:f2}%");
             Console.WriteLine ($"{everest:f2}%");
        }
    }
}
