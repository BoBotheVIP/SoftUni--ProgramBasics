using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            for(int i = 0; i < n; i++)
            {
                leftSum=leftSum + int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                rightSum = rightSum + int.Parse(Console.ReadLine());
            }
            if(leftSum== rightSum)
            {
                Console.WriteLine("Yes, sum = " + leftSum);
            }
            else
            {
                int diff=Math.Abs(leftSum-rightSum);
                Console.WriteLine("No, diff = " +diff);
            }
        }
    }
}