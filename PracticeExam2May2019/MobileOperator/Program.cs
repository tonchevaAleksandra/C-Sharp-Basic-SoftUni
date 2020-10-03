using System;

namespace MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
        
            string term = Console.ReadLine();
            string type = Console.ReadLine();
            string mobNet = Console.ReadLine();
            int cntMonths = int.Parse(Console.ReadLine());
            double currPrice = 0;

            if (term == "one")
            {
                switch (type)
                {
                    case "Small":
                        currPrice = 9.98;
                        break;
                    case "Middle":
                        currPrice = 18.99;
                        break;
                    case "Large":
                        currPrice = 25.98;
                        break;
                    case "ExtraLarge":
                        currPrice = 35.99;
                        break;
                }
            }

            else if (term == "two")
            {
                switch (type)
                {
                    case "Small":
                        currPrice = 8.58;
                        break;
                    case "Middle":
                        currPrice = 17.09;
                        break;
                    case "Large":
                        currPrice = 23.59;
                        break;
                    case "ExtraLarge":
                        currPrice = 31.79;
                        break;
                }
            
            }
            
            if (mobNet == "yes")
            {
                if (currPrice<=10.00)
                {
                    currPrice += 5.50;
                }
                else if(currPrice<=30.00)
                {
                    currPrice += 4.35;
                }
                else if (currPrice > 30.00)
                {
                    currPrice += 3.85;
                }
            }

            double totalPrice = currPrice * cntMonths;

            if(term=="two")
            {
                totalPrice = totalPrice - (3.75 * totalPrice / 100);
            }

            Console.WriteLine($"{totalPrice:f2} lv.");

        }
    }
}
