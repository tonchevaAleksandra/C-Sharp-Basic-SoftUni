using System;

namespace TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Вход
            // От конзолата първо се четат два реда:
            //• Брой турнири, в които е участвал – цяло число в интервала[1…20]
            //• Начален брой точки в ранглистата - цяло число в интервала[1...4000]
            //За всеки турнир се прочита отделен ред:
            //• Достигнат етап от турнира – текст – "W", "F" или "SF"
            int count = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());
            double countW = 0;
            double pointsW = 2000;
            double pointsF = 1200;
            double pointsSF = 720;
            double totalpoints = 0;
            for (int i = 0; i < count; i++)
            {
                string etap = Console.ReadLine();
                if (etap == "W")
                {
                  
                    totalpoints += pointsW; ;
                    countW++;
                    
                }

                else if (etap == "F")
                {
                    
                    totalpoints += pointsF;
                    
                    
                }
                else
                {
                    totalpoints += pointsSF;
                    
                    
                }
            }
            //            Отпечатват се три реда в следния формат:
            //• "Final points: {брой точки след изиграните турнири}"
            //• "Average points: {средно колко точки печели за турнир}"
            //• "{процент спечелени турнири}%"
            //Средните точки да бъдат закръглени към най - близкото цяло число надолу, а процентът да се форматира до
            //втората цифра след десетичния знак.
            
            Console.WriteLine($"Final points: {startPoints + totalpoints}");
            
            double averagePoints = Math.Floor(totalpoints / count);
            Console.WriteLine($"Average points: {averagePoints}");
            
            double persentWin = countW / count * 100;
            Console.WriteLine($"{persentWin:f2}%");
        }
    }
}
