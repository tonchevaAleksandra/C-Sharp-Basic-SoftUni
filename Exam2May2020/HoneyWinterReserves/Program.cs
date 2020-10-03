using System;

namespace HoneyWinterReserves
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double reserveHoney = double.Parse(Console.ReadLine());
            int months = 6;
            double totalHoney = 0;

            string nameBee = Console.ReadLine();
            while (nameBee!="Winter has come")
            {
                double honeyPerBee = 0;
                for (int i = 1; i <= months; i++)
                {
                    double producedHoney = double.Parse(Console.ReadLine());
                    honeyPerBee += producedHoney;
                }
                if(honeyPerBee<0)
                {
                    Console.WriteLine($"{nameBee} was banished for gluttony");
                    
                }

                totalHoney += honeyPerBee;
                nameBee = Console.ReadLine();

            }

            if(totalHoney>=reserveHoney)
            {
                Console.WriteLine($"Well done! Honey surplus {totalHoney-reserveHoney:f2}.");
            }
            else
            {
                Console.WriteLine($"Hard Winter! Honey needed {reserveHoney-totalHoney:f2}.");
            }


        }
    }
}
