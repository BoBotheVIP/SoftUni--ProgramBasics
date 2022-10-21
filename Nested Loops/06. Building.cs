using System;

namespace sumOfTwiNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int start =int.Parse(Console.ReadLine());
             int to=int.Parse(Console.ReadLine());
             int magicNumber=int.Parse(Console.ReadLine());
             bool isFound=false;
             int counter = 0;
            int firstNum = -1;
            int secondNum = -1;


             for(int n1 = start; n1 <= to; n1++)
            {
                for(int n2 = start; n2 <= to; n2++)
                {    
                    counter++;
                    if (n1 + n2 == magicNumber)
                    {
                       isFound=true;
                        firstNum=n1;
                        secondNum=n2;
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }
            if (isFound)
            {
                Console.WriteLine($"Combination N:{counter} ({firstNum} + {secondNum} = {magicNumber})");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
