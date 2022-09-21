using System;

namespace MyApp
{ 
     class Program
    {
        static void Main(string[] args)
        {


           


            string Name = Console.ReadLine();
             


            int Hours = int.Parse(Console.ReadLine());
            int Project = 3;
            int result = Hours * Project;

            Console.WriteLine($"The architect {Name} will need {result} hours to complete {Hours} project/s.");

             
        }

    }

}


