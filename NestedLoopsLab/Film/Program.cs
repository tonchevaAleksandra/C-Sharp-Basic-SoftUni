using System;

namespace TournamentOfChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double totalTickets = 0;
            double studentsTicket = 0;
            double standardTicket = 0;
            double kidTicket = 0;

            while (name != "Finish")
            {
                int capacity = int.Parse(Console.ReadLine());
                string ticketType = Console.ReadLine();
                double ticketsPerMovie = 0;
                while (ticketType != "End")
                {
                    ticketsPerMovie++;
                    if (ticketsPerMovie == capacity)
                    {
                        break;
                    }
                    if (ticketType == "student")
                    {
                        studentsTicket++;
                    }
                    else if (ticketType == "standard")
                    {
                        standardTicket++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidTicket++;
                    }

                    ticketType = Console.ReadLine();
                }

                totalTickets += ticketsPerMovie;

                Console.WriteLine($"{name} - {ticketsPerMovie / capacity * 100.0:f2}% full.");
                name = Console.ReadLine();
            }

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentsTicket / totalTickets * 100.0:F2}% student tickets.");
            Console.WriteLine($"{standardTicket / totalTickets * 100.0:f2}% standard tickets.");
            Console.WriteLine($"{kidTicket / totalTickets * 100.0:f2}% kids tickets.");


        }
    }
}