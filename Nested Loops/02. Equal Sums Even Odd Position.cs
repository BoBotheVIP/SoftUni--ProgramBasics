using System;

namespace equalSumsEvenOddPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int evenSum;
            int oddSum;
            string currNum;


            for(int i = firstNum; i <= secondNum; i++)
            {
                evenSum = 0;
                oddSum = 0;
                currNum = i.ToString();

                for(int j = 0; j < currNum.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        evenSum += currNum[j];
                    }
                    else
                    {
                        oddSum+=currNum[j];
                    }
                 
                }
                if (evenSum == oddSum)
                {
                    Console.Write($"{currNum} ");
                }
            }
        }
    }
}
