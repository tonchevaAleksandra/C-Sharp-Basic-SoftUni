using System;

namespace Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            //            . Височина на стената - цяло число[0… 100]
            //2.Ширина на стената -цяло число[0… 100]
            //3.Процент от общата площ на стените, който няма да бъде боядисан - цяло число[5… 95]
            //На следващите редове до получаване на командата "Tired!" или докато не бъдат боядисани всички
            //стени, се чете по едно число:
            //• Литри боя – цяло число[0…100]:
            //Забележка: Площта за боядисване да бъде закръглена нагоре до най - близкото цяло число.
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int persentNoPaint = int.Parse(Console.ReadLine());
            double surface = height * width * 4;
            surface = Math.Ceiling(surface - (persentNoPaint / 100.00 * surface));
            int paintedSurf = 0;
            string command = Console.ReadLine();
            while (command!="Tired!" )
            {
                int litters = int.Parse(command);
                paintedSurf += litters;
                if(paintedSurf>=surface)
                {
                    break;
                }

                command = Console.ReadLine();
                
            }
            if(command== "Tired!")
            {
                Console.WriteLine($"{Math.Ceiling(surface-paintedSurf)} quadratic m left.");
            }
            if(paintedSurf>surface)
            {
                Console.WriteLine($"All walls are painted and you have {paintedSurf-surface} l paint left!");
            }
            else if(paintedSurf==surface)
            {
                Console.WriteLine($"All walls are painted! Great job, Pesho!");
            }
        }
    }
}
