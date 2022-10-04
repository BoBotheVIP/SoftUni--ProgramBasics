using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;

            for(int i = 0; i < n; i++)
            {
                int currNumber = int.Parse(Console.ReadLine());

                if (currNumber > maxNumber)
                {
                    maxNumber = currNumber;
                }
                if(currNumber < minNumber)
                {
                    minNumber = currNumber;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
