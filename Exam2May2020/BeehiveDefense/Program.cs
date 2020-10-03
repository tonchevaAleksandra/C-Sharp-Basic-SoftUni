using System;

namespace BeehiveDefense
{
    class Program
    {
        static void Main(string[] args)
        {
           

            int cntBees = int.Parse(Console.ReadLine());
            int healthBear = int.Parse(Console.ReadLine());
            int attackBear = int.Parse(Console.ReadLine());
            //int healthBee = 1;
            int attackBee = 5;

            while(cntBees>=100)
            {
                cntBees -= attackBear;
                if(cntBees<=0)
                {
                    cntBees = 0;
                    break;
                }
                healthBear -= attackBee * cntBees;
                if(healthBear<=0 && cntBees>=100)
                {
                    Console.WriteLine($"Beehive won! Bees left {cntBees}.");
                    break;
                }
            }
            if(cntBees<100)
            {
                Console.WriteLine($"The bear stole the honey! Bees left {cntBees}.");
            }
        }
    }
}
