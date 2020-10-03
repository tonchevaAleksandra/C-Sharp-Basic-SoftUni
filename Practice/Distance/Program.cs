using System;

namespace Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Първоначалната скорост в км/ ч – цяло число в интервала[1 … 300].
            //Първото време в минути – цяло число в интервала[1 … 1000].
            //Второто време в минути – цяло число в интервала[1 … 1000].
            //Третото време в минути – цяло число в интервала[1 … 1000].

            int startSpeed = int.Parse(Console.ReadLine());
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            double firstKm = startSpeed*1.0 * (firstTime*1.0 / 60);
            double secondKm = startSpeed * 1.1 * (secondTime * 1.0 / 60);
            double thirdKm = ((startSpeed * 1.1) * 0.95) * (thirdTime * 1.0 / 60);
            double totalKm = firstKm + secondKm + thirdKm;
            Console.WriteLine($"{totalKm:f2}");


        }
}
}
