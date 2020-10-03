using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeY = Console.ReadLine();
            int pDays = int.Parse(Console.ReadLine());
            int hDays = int.Parse(Console.ReadLine());
            double weekEndsY = 48.0;
            double weekEndPlay = ( weekEndsY - hDays )*0.75 ;
            double pDaysPlay =2.0 * pDays/3.0;
            double totalPlays = weekEndPlay + pDaysPlay + hDays;
            if(typeY=="leap")
            {
                Console.WriteLine($"{Math.Floor(totalPlays*1.15)}");
                
            }
            else { 
            Console.WriteLine($"{Math.Floor(totalPlays)}");
        }

    }
    }
}
