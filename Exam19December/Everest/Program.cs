using System;

namespace Everest
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingPointMeters = 5364;
            int endPointMeters = 8848;

            string input = Console.ReadLine();
            
            int days = 1;
            while(input!="END" )
            {
                int meters = int.Parse(Console.ReadLine());
                if(input=="Yes")
                {
                    days++;
                }
                if(days>5)
                {
                    break;
                }

                startingPointMeters = startingPointMeters + meters;
                if(startingPointMeters>=endPointMeters)
                {
                    break;
                }
                input = Console.ReadLine();
            }

            if(startingPointMeters>=endPointMeters)
            {
                Console.WriteLine($"Goal reached for { days} days!");
            }
            else
            {
                Console.WriteLine("Failed!");
                Console.WriteLine($"{startingPointMeters}");
            }
        }
    }
}
