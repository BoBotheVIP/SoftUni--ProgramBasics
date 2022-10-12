using System;

namespace MinNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int maxNum = int.MaxValue;

            while (input != "Stop")
            {
                int num = int.Parse(input);
                if (num < maxNum)
                {
                    maxNum = num;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(maxNum);
        }
    }
}
