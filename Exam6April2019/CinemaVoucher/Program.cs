using System;

namespace CinemaVoucher
{
    class Program
    {
        static void Main(string[] args)
        {
            int voucher = int.Parse(Console.ReadLine());
            int counterTickets = 0;
            int price = 0;
            int countOthers = 0;

           
                string product = Console.ReadLine();
                while (product != "End")
                {
                    int currentPrice = 0;
                    if (product.Length > 8)
                    {
                        currentPrice = (int)product[0] + (int)product[1];
                        price += currentPrice;
                        counterTickets++;
                        if (price > voucher)
                        {
                            counterTickets--;

                        }

                    }
                    else if (product.Length <= 8)
                    {
                        currentPrice = (int)product[0];
                        price += currentPrice;
                        countOthers++;
                        if (price > voucher)
                        {
                            countOthers--;

                        }
                    }

                    if (price >= voucher)
                    {
                        break;
                    }
                    product = Console.ReadLine();
                    if(product=="End")
                    {
                        break;
                    }
                }
                
            
            Console.WriteLine($"{counterTickets}");
            Console.WriteLine($"{countOthers}");

        }
    }
}
