using System;

namespace Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name=Console.ReadLine();
            int badMarksCount = 0;
            int gradeNumber = 1;
            double totalMarks = 0;
            while (gradeNumber <= 12)
            {
                double mark=double.Parse(Console.ReadLine());
                totalMarks += mark;
                if (mark < 4)
                {
                    badMarksCount++;

                    if(badMarksCount > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {gradeNumber} grade");
                        return;
                    }
                }
                else
                {
                    gradeNumber++;
                }
            }
            double avarageGrade = totalMarks / (12 + badMarksCount);
            Console.WriteLine($"{name} graduated. Average grade: {avarageGrade:f2}");
        }
    }
}
