using System;

namespace HomeWork
{ 
     class Program
    {
        static void Main(string[] args)
        {
            int LenghtCM = int.Parse(Console.ReadLine());
            int WidthCM = int.Parse(Console.ReadLine());
            int HeightCM = int.Parse(Console.ReadLine());

            double Percentage = double.Parse(Console.ReadLine());

            int Volume = LenghtCM * WidthCM * HeightCM;
            double VolumeLitres = Volume * 0.001;
            double OccupiedSpace = Percentage / 100;

            Console.WriteLine(VolumeLitres * (1 - OccupiedSpace));

        }
    }
}


