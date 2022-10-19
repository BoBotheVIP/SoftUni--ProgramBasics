using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
          double neededMoney=double.Parse(Console.ReadLine());
          double avalibleMoney=double.Parse(Console.ReadLine());

            int dayCount = 0;
            int spendCount=0;

            string input;
            double money;

            while (avalibleMoney < neededMoney)
            {
                input = Console.ReadLine();
                money =double.Parse(Console.ReadLine());
                dayCount++;
                if (input == "save")
                {
                    avalibleMoney+=money;
                    spendCount = 0;                                  //nulirane na broqcha
                }
                else
                {
                    avalibleMoney-=money;
                    if(avalibleMoney < 0)
                    {
                        avalibleMoney=0;
                    }
                    spendCount++;
                    if(spendCount == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(dayCount);
                        break;
                    }
                }
                if (avalibleMoney >= neededMoney)
                {
                    Console.WriteLine($"You saved the money for {dayCount} days.");
                }
            }
        }
    }
}
