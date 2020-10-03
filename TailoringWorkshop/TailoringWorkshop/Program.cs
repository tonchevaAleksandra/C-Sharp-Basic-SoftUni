using System;

namespace TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int countTables = int.Parse(Console.ReadLine());
            double lengthTable = double.Parse(Console.ReadLine());
            double widthTable = double.Parse(Console.ReadLine());
            double totalAreaTablecloth = countTables * (lengthTable + 2 * 0.30) * (widthTable + 2 * 0.30);
            double totalAreaQuads = countTables * (lengthTable / 2) * (lengthTable / 2);
            double priceDollars = totalAreaTablecloth * 7 + totalAreaQuads * 9;
            double priceBgn = priceDollars * 1.85;
            Console.WriteLine($"{priceDollars:F2} USD");
            Console.WriteLine($"{priceBgn:F2} BGN");


        }
    }
}
