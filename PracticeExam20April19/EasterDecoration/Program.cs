using System;

namespace EasterDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int cntClients = int.Parse(Console.ReadLine());
            double totalBill = 0;

            for (int i = 0; i < cntClients; i++)
            {
                double currBill = 0;
                double cntProduct = 0;

                string product = Console.ReadLine();
                while (product != "Finish")
                {
                    cntProduct++;

                    switch (product)
                    {
                        
                        case "basket":currBill += 1.50;
                            break;
                        case "wreath":currBill += 3.80;
                            break;
                        case "chocolate bunny":currBill += 7.00;
                            break;

                    }
                    
                    product = Console.ReadLine();

                }
                if (cntProduct % 2 == 0)
                {
                    currBill *= 0.80;
                }

                totalBill += currBill;
                
                if (product == "Finish")
                {
                    Console.WriteLine($"You purchased {cntProduct} items for {currBill:f2} leva.");
                }

            }

            double averageBill = totalBill / cntClients;
            Console.WriteLine($"Average bill per client is: {averageBill:f2} leva.");
        }
    }
}
