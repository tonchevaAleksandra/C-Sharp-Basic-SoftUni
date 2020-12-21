using System;

namespace Worckout
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double killometers = double.Parse(Console.ReadLine());
            double totalKillometers = killometers;
            for (int i = 0; i < days; i++)
            {
                double percent = double.Parse(Console.ReadLine());
                killometers += killometers * percent / 100;
                totalKillometers += killometers;
            }

            if(totalKillometers>=1000)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(totalKillometers - 1000)} more kilometers!");
            }
            else
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000- totalKillometers)} more kilometers");
            }


        }
    }
}
