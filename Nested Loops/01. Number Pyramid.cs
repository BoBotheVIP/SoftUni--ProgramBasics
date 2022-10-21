using System;

namespace numberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n =int.Parse(Console.ReadLine());
            int currNum = 1;

            for(int row = 0; row <= n; row++)
            {
                for(int col = 1; col <= row; col++)
                {
                    Console.Write($"{currNum} ");
                    currNum++;

                    if(currNum > n)
                    {
                        return;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
