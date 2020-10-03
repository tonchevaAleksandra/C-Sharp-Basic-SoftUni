using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            int capacity = int.Parse(Console.ReadLine());
            int counter = 0;
            string name = Console.ReadLine();
            bool found = false;
            while(counter<capacity)
            {
                if(name==bookName)
                {
                    found = true; 
                    
                    break;
                }
                counter++;
                name = Console.ReadLine();
            }
            if(found)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {capacity} books.");
            }

        }
    }
}
