using System;

namespace HalfSumElement


{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNum = int.MinValue;  //vrushta nai malkata stoinost koqto int promenlivata moje da pazi
            int num ;
            for(int i = 0; i < n; i++)
            {
                 num = int.Parse(Console.ReadLine());
                sum += num;

                if (num > maxNum)
                {
                    maxNum = num;
                }
            }
            sum=sum-maxNum;
            if (sum == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNum-sum)}");
            } 
        }
    }
}
