using System;

namespace Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Вход
            // От конзолата се четат следните редове:
            //            1.Височина на стената -цяло число[0… 100]
            //2.Ширина на стената -цяло число[0… 100]
            //3.Процент от общата площ на стените, който няма да бъде боядисан - цяло число[5… 95]
            //На следващите редове до получаване на командата "Tired!" или докато не бъдат боядисани всички
            //стени, се чете по едно число:
            //• Литри боя – цяло число[0…100]:
            //Забележка: Площта за боядисване да бъде закръглена нагоре до най - близкото цяло число.
            int h = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int percentageNopaint = int.Parse(Console.ReadLine());
            double surface = h * w * 4.00;
            surface = Math.Ceiling(surface - (percentageNopaint / 100.00 * surface));
            int totalPaint = 0;
            string command = Console.ReadLine();
            while (command != "Tired!")
            {
                int paint = int.Parse(command);

                totalPaint += paint;
                if (surface <= totalPaint)
                {
                    break;
                }
                command = Console.ReadLine();
            }
            if (command == "Tired!")
            {
                Console.WriteLine($"{surface - totalPaint} quadratic m left.");
            }
            if (totalPaint > surface)
            {
                Console.WriteLine($"All walls are painted and you have {totalPaint - surface} l paint left!");
            }
            else if (totalPaint == surface)
            {
                Console.WriteLine($"All walls are painted! Great job, Pesho!");
            }
        }
    }
}
