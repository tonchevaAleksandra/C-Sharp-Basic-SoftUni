using System;

namespace FuelTank2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double litersFuel = double.Parse(Console.ReadLine());
            string yesOrNo = Console.ReadLine();
            double priceGasoline = 2.22;
            double priceGas = 0.93;
            double priceDiesel = 2.33;
            double priceGasolineDiscount = priceGasoline - 0.18;
            double priceGasDiscount = priceGas - 0.08;
            double priceDieselDiscount = priceDiesel - 0.12;
            if (litersFuel < 20 && yesOrNo == "Yes")
            {
                if (fuel == "Gasoline")
                {
                    Console.WriteLine($"{priceGasolineDiscount * litersFuel:F2} lv.");
                }
                else if (fuel == "Gas")
                {
                    Console.WriteLine($"{priceGasDiscount * litersFuel:F2} lv.");
                }
                else if (fuel == "Diesel")
                {
                    Console.WriteLine($"{priceDieselDiscount * litersFuel:F2} lv.");
                }
            }
            else if (litersFuel < 20 && yesOrNo == "No")
            {
                if (fuel == "Gasoline")
                {
                    Console.WriteLine($"{priceGasoline * litersFuel:F2} lv.");
                }
                else if (fuel == "Gas")
                {
                    Console.WriteLine($"{priceGas * litersFuel:F2} lv.");
                }
                else if (fuel == "Diesel")
                {
                    Console.WriteLine($"{priceDiesel * litersFuel:F2} lv.");
                }
            }
            else if (litersFuel >= 20 && litersFuel <= 25)
            {
                if (yesOrNo == "Yes")
                {
                    if (fuel == "Gasoline")
                    {
                        Console.WriteLine($"{priceGasolineDiscount * litersFuel * 0.92:F2} lv.");
                    }
                    else if (fuel == "Gas")
                    {
                        Console.WriteLine($"{priceGasDiscount * litersFuel * 0.92:F2} lv.");
                    }
                    else if (fuel == "Diesel")
                    {
                        Console.WriteLine($"{priceDieselDiscount * litersFuel * 0.92:F2} lv.");
                    }
                }
                else if (yesOrNo == "No")
                {
                    if (fuel == "Gasoline")
                    {
                        Console.WriteLine($"{priceGasoline * litersFuel * 0.92:F2} lv.");
                    }
                    else if (fuel == "Gas")
                    {
                        Console.WriteLine($"{priceGas * litersFuel * 0.92:F2} lv.");
                    }
                    else if (fuel == "Diesel")
                    {
                        Console.WriteLine($"{priceDiesel * litersFuel * 0.92:F2} lv.");
                    }
                }
            }
            else if (litersFuel > 25)
            {
                if (yesOrNo == "Yes")
                {
                    if (fuel == "Gasoline")
                    {
                        Console.WriteLine($"{priceGasolineDiscount * litersFuel * 0.90:F2} lv.");
                    }
                    else if (fuel == "Gas")
                    {
                        Console.WriteLine($"{priceGasDiscount * litersFuel * 0.90:F2} lv.");
                    }
                    else if (fuel == "Diesel")
                    {
                        Console.WriteLine($"{priceDieselDiscount * litersFuel * 0.90:F2} lv.");
                    }
                }
                else if (yesOrNo == "No")
                {
                    if (fuel == "Gasoline")
                    {
                        Console.WriteLine($"{priceGasoline * litersFuel * 0.90:F2} lv.");
                    }
                    else if (fuel == "Gas")
                    {
                        Console.WriteLine($"{priceGas * litersFuel * 0.90:F2} lv.");
                    }
                    else if (fuel == "Diesel")
                    {
                        Console.WriteLine($"{priceDiesel * litersFuel * 0.90:F2} lv.");
                    }
                }
            }
            
           
        }
    }
}





