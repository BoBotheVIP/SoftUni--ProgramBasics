 using System;

namespace YardGreening
{
class Programe
    {
        static void Main(string[] args)
        {

            double Kvm = double.Parse(Console.ReadLine());
            double Kvmp = 7.61;
            double sum = Kvm * Kvmp;

            double Disc = 0.18;
            double Discf = sum * Disc;

            double Fnp = sum - Discf;

            Console.WriteLine($"The final price is: {Fnp} lv.");
            Console.WriteLine($"The discount is: {Discf} lv." );


           
        }


    }



}
