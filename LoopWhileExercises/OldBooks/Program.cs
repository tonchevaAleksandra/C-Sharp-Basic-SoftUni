using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int counter = 0;
            while (input!=favouriteBook && n>counter)
            {
                   counter++;
                input = Console.ReadLine();
            }
            if(input==favouriteBook)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {n} books.");
            }

        }
    }
}
