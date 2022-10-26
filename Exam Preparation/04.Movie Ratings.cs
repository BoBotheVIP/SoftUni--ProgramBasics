using System;

namespace MovieRatings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string maxRatingMovieName = string.Empty; //""
            double maxRating = double.MinValue; //0

            string minRatingMovieName = string.Empty;
            double minRating = double.MaxValue;

            double totalRating = 0;//Sum starts fom 0
            for (int i = 1; i <= n; i++)
            {
                string movieName = Console.ReadLine();
                double movieRating = double.Parse(Console.ReadLine());

                if (movieRating > maxRating)
                {
                    maxRatingMovieName = movieName;
                    maxRating = movieRating;
                }

                if (movieRating < minRating)
                {
                    minRatingMovieName = movieName;
                    minRating = movieRating;
                }

                totalRating += movieRating;
            }
            double avarageRating = totalRating / n;

            Console.WriteLine($"{maxRatingMovieName} is with highest rating: {maxRating:f1}");
            Console.WriteLine($"{minRatingMovieName} is with lowest rating: {minRating:f1}");
            Console.WriteLine($"Average rating: {avarageRating:f1}");

        }
    }
}
