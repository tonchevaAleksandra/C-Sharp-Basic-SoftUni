using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Широчина на свободното пространство - цяло число в интервала [1...1000]
            //  2.Дължина на свободното пространство - цяло число в интервала[1...1000]
            //3.Височина на свободното пространство - цяло число в интервала[1...1000]
            //4.На следващите редове(до получаване на команда  Done  -брой кашони, които се пренасят в квартирата - цели числа в интервала[1...10000];
            // Програмата трябва да приключи прочитането на данни при команда & quot; Done & quot; или ако свободното място свърши.
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int freeSpace = width * length * height;
            
            string command = Console.ReadLine();
            
            while (command!="Done")
            {
                int boxes= int.Parse(command);
                
                if(freeSpace>=boxes)
                {
                    freeSpace -= boxes;
                }
                else
                {
                    Console.WriteLine($"No more free space! You need {boxes-freeSpace} Cubic meters more.");
                    break;
                }
                command = Console.ReadLine();
            }
            if(command=="Done")
            { 
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }
        }
    }
}
            
            
                     
               
               




