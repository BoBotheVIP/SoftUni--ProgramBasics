using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int AllPages = int.Parse(Console.ReadLine());
            int PagesHour = int.Parse(Console.ReadLine());
            int Days = int.Parse(Console.ReadLine());
            int AllHours = AllPages / PagesHour;
            int DailyHours = AllHours / Days;
            Console.WriteLine(DailyHours);



        }
        
    }
}







