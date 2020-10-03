using System;

namespace SuitcasesLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Капацитетът на багажника – реално число в диапазона[100.0…6000.0]
            //След това до получаване на команда "End" или до запълване на багажника, се чете по един ред:
            //            o Обем на куфар – реално число в диапазона[100.0…6000.0]
            double capacity = double.Parse(Console.ReadLine());
            double volumeUsed = 0;
            int counterLuggage = 0;
            for (int i = 0; i < capacity; i++)
            {
                string input = Console.ReadLine();
                if (input == "End" && capacity != 0)
                {
                    Console.WriteLine($"Congratulations! All suitcases are loaded!");
                    break;
                }

                double currentVol = double.Parse(input);
                if (i % 3 == 0)
                {
                    currentVol = 1.1 * currentVol;
                }
                if (currentVol > capacity)
                {
                    Console.WriteLine($"No more space!");
                    break;
                }
                counterLuggage++;
                volumeUsed += currentVol;
                capacity -= currentVol;


            }

            Console.WriteLine($"Statistic: {counterLuggage} suitcases loaded.");



        }
    }
}
