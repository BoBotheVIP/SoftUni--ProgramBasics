using System;

namespace NumbersN1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int number =int.Parse(Console.ReadLine()); number >= 1; --number)
            {
                Console.WriteLine(number);
            }
        }
    }
}
