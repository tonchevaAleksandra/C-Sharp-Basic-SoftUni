using System;

namespace WorldSnookerChampionship
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Етап на първенството – текст - “Quarter final ”, “Semi final” или “Final”
            //2. Вид на билета – текст - “Standard”, “Premium” или “VIP”
            //3. Брой билети – цяло число в интервала [1 … 30]
            //4. Снимка с трофея – символ – 'Y' (да) или 'N' (не)
            string etap = Console.ReadLine();
            string ticket = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            char symbol = Convert.ToChar(Console.ReadLine());
            double photo = 40.0;
            double price = 0.0;
            
            if (ticket == "Standard")
            {
                if (etap == "Quarter final")
                {
                    price = 55.50 * quantity;
                }
                else if (etap == "Semi final")
                {
                    price = 75.88 * quantity;
                }
                else if (etap == "Final")
                {
                    price = 110.10 * quantity;
                }
            }
            else if (ticket == "Premium")
            {
                if (etap == "Quarter final")
                {
                    price = 105.20 * quantity;
                }
                else if (etap == "Semi final")
                {
                    price = 125.22 * quantity;
                }

                else if (etap == "Final")
                {
                    price = 160.66 * quantity;
                }
            }
            else if (ticket == "Premium")
            {
                if (etap == "Quarter final")
                {
                    price = 105.20 * quantity;
                }
                else if (etap == "Semi final")
                {
                    price = 125.22 * quantity;
                }
                else if (etap == "Final")
                {
                    price = 160.66 * quantity;
                }
            }
            else if (ticket == "VIP")
            {
                if (etap == "Quarter final")
                {
                    price = 118.90 * quantity;

                }
                else if (etap == "Semi final")
                {
                    price = 300.40 * quantity;
                }
                else if (etap == "Final")
                {
                    price = 400 * quantity;
                }
            }
            if ((price > 4000)&& (symbol == 'Y' || symbol == 'N'))
            {
                  price = price * 0.75; 
            }
            else if(price>2500 && price<=4000)
            {
                if (symbol == 'Y')
                {
                    price = (price * 0.9) + (photo * quantity);
                }
                else
                {
                    price = price * 0.9;
                }
            }
            else if(price<=2500)
            {
                if (symbol == 'Y')
                {
                    price = price  + (photo * quantity);
                }
                else if(symbol == 'N')
                {
                    price = price * 1.0;
                }
            }
            Console.WriteLine($"{price:f2}");
        }

    }
}
        
        
            
























