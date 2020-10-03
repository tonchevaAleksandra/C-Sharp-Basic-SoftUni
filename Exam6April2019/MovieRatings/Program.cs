using System;

namespace MovieRatings
{
    class Program
    {
        static void Main(string[] args)
        {
            //            От конзолата първо се чете един ред:
            //• Брой филми, които си е набелязала Деси – цяло число в интервала[1…20]
            //За всеки филм се прочитат два отделни реда:
            //• Име на филма – текст
            //• Рейтинг на филма - реално число в интервала[1.00…10.00]
            int movies = int.Parse(Console.ReadLine());
            double totalRate = 0;
            double maxRate = double.MinValue;
            double minRate = double.MaxValue;
            string maxName = "";
            string minName = "";
            for (int i = 0; i < movies; i++)
            {
                string name = Console.ReadLine();
                double rate = double.Parse(Console.ReadLine());
                totalRate += rate;
                if(rate>maxRate)
                {
                    maxRate = rate; maxName = name;
                }
                else if(rate<minRate)
                {
                    minRate = rate; minName = name;
                }
                    
            }

            Console.WriteLine($"{maxName} is with highest rating: {maxRate:f1}");
            Console.WriteLine($"{minName} is with lowest rating: {minRate:f1}");
            double averageRate = totalRate / movies;
            Console.WriteLine($"Average rating: {averageRate:f1}");
        }
    }
}
