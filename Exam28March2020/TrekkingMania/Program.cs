using System;

namespace TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            //            На първия ред – броя на групите от катерачи – цяло число в интервала[1...1000]
            // За всяка една група на отделен ред – броя на хората в групата – цяло число в интервала[1...1000]
            int countGroops = int.Parse(Console.ReadLine());
            double musalaPpl = 0;
            double monBlanPpl = 0;
            double killiMPpl = 0;
            double k2Ppl = 0;
            double everestPpl = 0;
            double totalPpl = 0;
            //            Група до 5 човека– Мусала
            // Група от 6 до 12 – Монблан
            // Група от 13 до 25 – Килиманджаро
            // Група от 26 до 40 – К2
            // Група от 41 или повече – Еверест
            for (int i = 1; i <= countGroops; i++)
            {
                int people = int.Parse(Console.ReadLine());
                totalPpl += people;
                if (people<=5)
                {
                    musalaPpl += people;
                }
                else if(people>5 && people<=12)
                {
                    monBlanPpl += people;
                }
                else if(people>12 && people<=25)
                {
                    killiMPpl += people;
                }
                else if(people>25 && people<=40)
                {
                    k2Ppl += people;
                }
                else
                {
                    everestPpl += people;
                }

            }
            double musala = musalaPpl / totalPpl * 100;
            double monBlan = monBlanPpl / totalPpl * 100;
            double killimandjaro = killiMPpl / totalPpl * 100;
            double k2 = k2Ppl / totalPpl * 100;
            double everest = everestPpl / totalPpl * 100;
            Console.WriteLine($"{musala:f2}%");
            Console.WriteLine($"{monBlan:f2}%");
            Console.WriteLine($"{killimandjaro:f2}%");
            Console.WriteLine($"{k2:f2}%");
            Console.WriteLine($"{everest:f2}%");
        }
    }
}
