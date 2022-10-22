using System;

namespace sumPrimeNonPrime

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeSum = 0;
            int nonPrimeSum = 0;
            string input = Console.ReadLine();
            int currNum;

            while(input != "stop")
            {
                currNum = int.Parse(input);

                if (currNum < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }

                bool isPrime=true;

                for(int i = 2; i < currNum; i++)
                {
                    if(currNum % i == 0)
                    {
                        isPrime=false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeSum+=currNum;
                }
                else
                {
                    nonPrimeSum+=currNum;
                }

                input = Console.ReadLine();
            }
              Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
