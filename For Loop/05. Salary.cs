using System;

namespace Salary


{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabs =int.Parse(Console.ReadLine());
            int salary =int.Parse(Console.ReadLine());
            string site;

            for(int i = 0; i < tabs; i++)
            {    
                site = Console.ReadLine();
                if (site == "Facebook")
                {
                    salary = salary - 150;
                }
                else if (site == "Instagram")
                {
                    salary = salary - 100;
                }
                else if(site == "Reddit")
                {
                    salary = salary - 50;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if(salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
