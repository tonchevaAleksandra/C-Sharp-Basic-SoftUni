using System;

namespace Reservation
{
    class Program
    {
        static void Main(string[] args)
        {
            int dateOfReservation = int.Parse(Console.ReadLine());
            int monthOFReservation = int.Parse(Console.ReadLine());
            int dayOfAccommodation = int.Parse(Console.ReadLine());
            int monthOfAccommodation = int.Parse(Console.ReadLine());
            int dayOfLeaving = int.Parse(Console.ReadLine());
            int monthOfLeaving = int.Parse(Console.ReadLine());
            int countDays = dayOfLeaving - dayOfAccommodation;
            double price = countDays * 30;
            if (dateOfReservation <= dayOfAccommodation - 10) { price = countDays * 25; }
            else if (monthOFReservation < monthOfAccommodation) { price = (countDays * 25) - (0.2 * (countDays * 25)); }
            
            Console.WriteLine($"Your stay from {dayOfAccommodation}/{monthOfAccommodation} to {dayOfLeaving}/{monthOfLeaving} will cost {price:F2}");
           
        }
    }
}
