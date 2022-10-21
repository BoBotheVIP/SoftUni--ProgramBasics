using System;

namespace travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            double neededMoney;
            double num;
            double sum = 0;


            while (true)
            {
                input = Console.ReadLine();
                if (input == "End")
                {
                    return;
                }
                neededMoney = double.Parse(Console.ReadLine());
                while (true)
                {
                    num = double.Parse(Console.ReadLine());
                    sum += num;
                    if (sum >= neededMoney)
                    {
                        Console.WriteLine($"Going to {input}!");
                        sum= 0;
                        break;

                    }
                }
                
            }
        }
    }
}
