using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            //            На първия ред до получаване на командата "Finish" - име на филма – текст
            //• На втори ред – свободните места в салона за всяка прожекция – цяло число[1 … 100]
            //• За всеки филм, се чете по един ред до изчерпване на свободните места в залата или до получаване на
            //командата "End":
            //o Типа на закупения билет - текст("student", "standard", "kid")
            string movie = Console.ReadLine();
            double totalTickets = 0;
            double countSt = 0;
            double countStnd = 0;
            double countKids = 0;

            while (movie !="Finish")
            {
                double countTickets = 0;
                int freeSeats = int.Parse(Console.ReadLine());
                string ticketType = Console.ReadLine();
                while (ticketType !="End" )
                {
                    switch (ticketType)
                    {
                        case "student": countSt++;
                            break;
                        case "standard": countStnd++;
                            break;
                        case "kid":countKids++;
                            break;
                        default :
                            break;
                    }
                    countTickets++;
                    if (countTickets == freeSeats)
                    {
                        break;
                    }

                    ticketType = Console.ReadLine();
                    
                }
                double persentPerMovie = countTickets / freeSeats * 100.00;
                Console.WriteLine($"{movie} - {persentPerMovie:f2}% full.");
                totalTickets += countTickets;
               
                movie = Console.ReadLine();
                
            }

            if (movie =="Finish")
            {
                Console.WriteLine($"Total tickets: {totalTickets}");
                double persentStudents = countSt * 100.00 / totalTickets;
                double persentStandard = countStnd * 100.00 / totalTickets;
                double persentKids = countKids * 100.00 / totalTickets ;
                Console.WriteLine($"{persentStudents:f2}% student tickets.");
                Console.WriteLine($"{persentStandard:f2}% standard tickets.");
                Console.WriteLine($"{persentKids:f2}% kids tickets.");
            }

            
        }
    }
}
