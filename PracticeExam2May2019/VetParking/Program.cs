using System;

namespace VetParking
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            for (int i = 1; i <= days; i++)
            {
                double currPrice = 0;

                for (int j = 1; j <= hours; j++)
                {
                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        currPrice += 2.50;
                    }
                    else if (i % 2 != 0 && j % 2 == 0)
                    {
                        currPrice += 1.25;
                    }
                    else
                    {
                        currPrice += 1.00;
                    }
                }

                Console.WriteLine($"Day: {i} - {currPrice:f2} leva");
                totalPrice += currPrice;

            }

            Console.WriteLine($"Total: {totalPrice:f2} leva");
        }
    }
}
