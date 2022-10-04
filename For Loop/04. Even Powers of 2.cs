using System;

namespace EvenPowersof2

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            for (int pow = 0; pow <= num1; pow+=2 )
            {             
                    Console.WriteLine(Math.Pow(2, pow));
                
            }
        }
    }
}
