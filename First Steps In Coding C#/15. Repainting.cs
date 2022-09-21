using System;

namespace HomeWork
{ 
     class Program
    {
        static void Main(string[] args)
        {
            int AmountOfNylon = int.Parse(Console.ReadLine());
            int AmountOfPaint = int.Parse(Console.ReadLine());
            int AmountOfDiluent = int.Parse(Console.ReadLine());
            int WorkersTime = int.Parse(Console.ReadLine());

            double NylonPrice = (AmountOfNylon + 2) * 1.5;
            double PaintPrice = (AmountOfPaint + 0.1 * AmountOfPaint) * 14.5;
            double DiluentPrice = AmountOfDiluent * 5;

            double MaterialsSum = NylonPrice + PaintPrice + DiluentPrice + 0.4;
            double WorkersSun = (MaterialsSum * 0.3) * WorkersTime;

            double TotalSum = MaterialsSum + WorkersSun;
            
            Console.WriteLine(TotalSum);
        }
    }
}


