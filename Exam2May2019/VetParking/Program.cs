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
                double pricePerDay = 0;

                if(i%2==0)
                {
                    for (int j = 1; j <= hours; j++)
                    {
                        if(j%2==0)
                        {
                            pricePerDay += 1.00;
                        }
                        else
                        {
                            pricePerDay += 2.50;
                        }
                    }
                }

                if (i % 2 != 0)
                {
                    for (int j = 1; j <= hours; j++)
                    {
                        if (j % 2 == 0)
                        {
                            pricePerDay += 1.25;
                        }
                        else
                        {
                            pricePerDay += 1.00;
                        }

                    }

                }

                totalPrice += pricePerDay;
                Console.WriteLine($"Day: {i} - {pricePerDay:f2} leva");
            }

            Console.WriteLine($"Total: {totalPrice:f2} leva");
        }
    }
}
