using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string movie = Console.ReadLine();
            int totalTickets = 0;
            int countStudTicket = 0;
            int countStandardT = 0;
            int countKidticket = 0;
       
            while (movie != "Finish")
            {
                int capacity = int.Parse(Console.ReadLine());
                string ticketType = Console.ReadLine();
                int ticketsPerMovie = 0;

                while  (ticketType !="End" )
                {
                    switch (ticketType)
                    {
                        case "student":countStudTicket++; 
                            break;
                        case "standard": countStandardT++; 
                            break;
                        case "kid": countKidticket++; 
                            break;
                    }
         
                    ticketsPerMovie++;
                    if(ticketsPerMovie==capacity)
                    {
                        break;
                    }
                    ticketType = Console.ReadLine();
                   
                }

                double persentage = ticketsPerMovie * 100.00 / capacity;
                Console.WriteLine($"{movie} - {persentage:f2}% full.");
                totalTickets += ticketsPerMovie;
                movie = Console.ReadLine();
                if (movie == "Finish")
                {
                    break;
                }
             
            }

            double persentageStudents = countStudTicket * 100.00 / totalTickets ;
            double persentageStandard = countStandardT * 100.00 / totalTickets;
            double persentageKid = countKidticket * 100.00 / totalTickets;

            if(movie == "Finish")
            {
                Console.WriteLine($"Total tickets: {totalTickets}");
                Console.WriteLine($"{persentageStudents:f2}% student tickets.");
                Console.WriteLine($"{persentageStandard:f2}% standard tickets.");
                Console.WriteLine($"{persentageKid:f2}% kids tickets.");

            }

        }
    }
}

