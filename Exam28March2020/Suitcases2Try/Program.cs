using System;

namespace Suitcases2Try
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            bool isTrue = false;
            int counterLuggage = 0;
            while (capacity>=0)
            {
                string command = Console.ReadLine();
                if(command=="End")
                {
                    isTrue = true;
                    break;
                }
                double currentVol = double.Parse(command);
                if (counterLuggage % 3 == 0 && counterLuggage !=0)
                {
                    currentVol *= 1.1;
                }
               
                counterLuggage+=1;
                
                capacity -= currentVol;
            }
            if (isTrue)

                Console.WriteLine("Congratulations! All suitcases are loaded!");
            else
            {
                counterLuggage -= 1;
                Console.WriteLine("No more space!");
            }
           
            Console.WriteLine($"Statistic: {counterLuggage} suitcases loaded.");
        }
    }
}
