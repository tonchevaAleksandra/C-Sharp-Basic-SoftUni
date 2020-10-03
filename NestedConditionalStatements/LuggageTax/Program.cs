using System;

namespace LuggageTax
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Първи ред – ширина на куфара – цяло число в интервала от [1… 10]
            // 2.Втори ред – височина на куфара – цяло число в интервала от[1… 10]
            //3.Трети ред – дълбочина на куфара – цяло число в интервала от[1… 10]
            //4.Четвърти ред – дали билета ѝ е priority или не – текст с възможности "true" или "false"
            //Въведените числа са в дециметри.

            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int depth = int.Parse(Console.ReadLine());
            string priority =  Console.ReadLine();
            int volume = 0;
            double taxe = 0.0;
           volume = width * height * depth;
             if (volume <= 50)
            {
                if (priority == "true")
                {
                    taxe = 0.0;
                }
                else if (priority == "false")
                {
                    taxe = 0.0;
                }
            }
            else if (volume>50 && volume<=100)
            {
                if (priority == "true")
                {
                    taxe = 0.0;
                }
                else if(priority=="false")
                {
                    taxe = 25.00;
                }
            }
            else if (volume > 100 && volume <= 200)
            {
                if (priority == "true")
                {
                    taxe = 10.0;
                }
                else if (priority == "false")
                {
                    taxe = 50.00;
                }
            }
            else if (volume > 200 && volume <= 300)
            {
                if (priority == "true")
                {
                    taxe = 20.0;
                }
                else if (priority == "false")
                {
                    taxe = 100.00;
                }
            }
            
            Console.WriteLine($"Luggage tax: {taxe:f2}");


        }
    }
}
