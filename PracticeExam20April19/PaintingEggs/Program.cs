using System;

namespace PaintingEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string size = Console.ReadLine();
            string color = Console.ReadLine();
            int cnt = int.Parse(Console.ReadLine());
            double price = 0;

            if (size == "Large")
            {

                switch (color)
                {
                    case "Red": price = cnt * 16.00;
                        break;
                    case "Green":
                        price = cnt * 12.00;
                        break;
                    case "Yellow":
                        price = cnt * 9.00;
                        break;
                }
            }

            else if (size == "Medium")
            { switch (color)
                {
                    case "Red":
                        price = cnt * 13.00;
                        break;
                    case "Green":
                        price = cnt * 9.00;
                        break;
                    case "Yellow":
                        price = cnt * 7.00;
                        break;
                }
            }
            else if (size == "Small")
            {
                switch (color)
                {
                    case "Red":
                        price = cnt * 9.00;
                        break;
                    case "Green":
                        price = cnt * 8.00;
                        break;
                    case "Yellow":
                        price = cnt * 5.00;
                        break;
                }
            }
            double profit = price * 0.65;
            Console.WriteLine($"{profit:f2} leva.");
        
        }
    }
}
