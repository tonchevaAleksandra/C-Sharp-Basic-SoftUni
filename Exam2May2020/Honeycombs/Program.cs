using System;

namespace Honeycombs
{
    class Program
    {
        static void Main(string[] args)
        {

            int cntBees = int.Parse(Console.ReadLine());
            int cntFlowers = int.Parse(Console.ReadLine());
           
            double grBeePerFlower = 0.21;
            double capacity1Comb = 100.00;
            double totalHoney = cntBees * grBeePerFlower * cntFlowers;
            double honeycombs = Math.Floor(totalHoney / capacity1Comb);
            double lefHoney = totalHoney - (honeycombs*capacity1Comb);

            Console.WriteLine($"{honeycombs} honeycombs filled.");
            Console.WriteLine($"{lefHoney:f2} grams of honey left.");



        }
    }
}
