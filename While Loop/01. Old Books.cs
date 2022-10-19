using System;

namespace OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string annyBook = Console.ReadLine();
            string currBook=Console.ReadLine();
            int counter=0;

            while (currBook!="No More Books")                 //dokato e razl ot No More Books
            {
                if (annyBook == currBook)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    break;                                                             //spira zashtoto e namerilo 
                                                                                        // knigata
                }
                counter++;
                currBook=Console.ReadLine();
            }
            if(currBook== "No More Books")
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
