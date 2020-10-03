using System;

namespace Suitcases100Points
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int counter = 0;
            
            double volume = 0;
            while(command !="End")
            {
                volume=double.Parse(command);
                counter++;
                if (counter%3==0 && counter !=0)
                {
                    volume *= 1.1;
                }
                if(capacity<volume)
                {
                    counter--;
                    break;
                }
                capacity -= volume;
                
                command = Console.ReadLine();
            }
            if(command=="End")
            {
                Console.WriteLine($"Congratulations! All suitcases are loaded!");
            }
            if(capacity<volume && command !="End")
            {
                Console.WriteLine($"No more space!");
            }
            Console.WriteLine($"Statistic: {counter} suitcases loaded.");
        }
    }
}
