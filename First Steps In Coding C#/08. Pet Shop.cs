using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {

            Double Dogs = float.Parse(Console.ReadLine());
            Double Cat = int.Parse(Console.ReadLine());

            Double DogsFood = 2.5;
            Double CatFood = 4;

            Double Sum = Dogs * DogsFood + Cat * CatFood;
            Console.WriteLine($"{Sum} lv."); 


        }


    }


}
