using System;

namespace ReadText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "Stop")
            {
                Console.WriteLine(input);
            }
        }
    }
}
