using System;

namespace MovieProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameMovie = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int countTickets = int.Parse(Console.ReadLine());
            double priceTicket = double.Parse(Console.ReadLine());
            int percentage = int.Parse(Console.ReadLine());
            double totalprofit = days * (countTickets * priceTicket);
            double profitCinema = percentage * totalprofit / 100.00;
            double profit = totalprofit - profitCinema;
            
            Console.WriteLine($"The profit from the movie {nameMovie} is {profit:F2} lv.");
        }
    }
}
