using System;

namespace homeWork

{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());

            minutes = minutes + 15; 
            if(minutes > 59)
            {
                hour = hour + 1;
                minutes = minutes - 60;
            }
            if(hour > 23)
            {
                hour = 0;
            }
            if(minutes < 10)
            {
                Console.WriteLine(hour +":0"+minutes); 
            }
            else
            {
                Console.WriteLine(hour + ":"+ minutes);
            }
        }
    }
}
