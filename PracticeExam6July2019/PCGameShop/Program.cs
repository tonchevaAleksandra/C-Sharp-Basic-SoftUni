using System;

namespace PCGameShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double cntHS = 0;
            double cntF = 0;
            double cntO = 0;
            double cntOthers = 0;

            for (int i = 0; i < n; i++)
            {
                string game = Console.ReadLine();
                switch (game)
                {
                    case "Hearthstone":
                        cntHS++;
                        break;
                    case "Fornite":
                        cntF++;
                        break;
                    case "Overwatch":
                        cntO++;
                        break;
                    default:
                        cntOthers++;
                        break;
                }
            }
            double persentHS = cntHS / n * 100.00;
            double persentF = cntF / n * 100.00;
            double persentO = cntO / n * 100.00;
            double persentOthers = cntOthers / n * 100.00;

            Console.WriteLine($"Hearthstone - {persentHS:f2}%");
            Console.WriteLine($"Fornite - {persentF:f2}%");
            Console.WriteLine($"Overwatch - {persentO:f2}%");
            Console.WriteLine($"Others - {persentOthers:f2}%");
        }
    }
}
