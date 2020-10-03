using System;

namespace PCGameShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Вход
            // От конзолата се четат:
            //• Брой продадени игри - n - цяло положително число в интервала[1… 100]
            //За следващите n реда се чете по един ред:
            //            o Име на игра -текст
            int n = int.Parse(Console.ReadLine());
            double countHS = 0;
            double countF = 0;
            double countO = 0;
            double countOther = 0;
            //            Hearthstone
            //• Fornite
            //• Overwatch
            //• Others
            for (int i = 0; i < n; i++)
            {
                string game = Console.ReadLine();
                switch (game)
                {
                    case "Hearthstone": countHS++;
                        break;
                    case "Fornite":countF++;
                        break;
                    case "Overwatch":countO++;
                        break;
                   default: countOther++;
                        break;
                }

            }
            double persH = countHS / n * 100.00;
            double persF = countF / n * 100.00;
            double persO = countO / n * 100.00;
            double persOther = countOther / n * 100.00;
            Console.WriteLine($"Hearthstone - {persH:f2}%");
            Console.WriteLine($"Fornite - {persF:f2}%");
            Console.WriteLine($"Overwatch - {persO:f2}%");
            Console.WriteLine($"Others - {persOther:f2}%");
        }
    }
}
