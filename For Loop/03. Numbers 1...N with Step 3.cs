using System;

namespace Numbers1NwithStep3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num2=int.Parse(Console.ReadLine());
            for (int number = 1; number <=num2 ; number+=3)
            {
                Console.WriteLine(number);
            }
        }
    }
}
