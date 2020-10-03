using System;

namespace HoneyWinterReserve
{
    class Program
    {
        static void Main(string[] args)
        {
            //          •	На първи ред получавате количесто мед за зимата: реално число[1.00 - 1000.00].
            //•	На следващите до получаване на "Winter has come"редове ще получавате:
            //            o Име на пчела: string
            //          o   На следващите 6 реда ще получавате добития от пчелата мед: реално число[-1000.00 - 1000.00]. 
            //o Ако накрая на 6 - те месеца пчелата е изяла повече мед, отколкото е събрала, принтирайте:
            //"{име на пчела} was banished for gluttony
            double reserveHoney = double.Parse(Console.ReadLine());
            
            string command = Console.ReadLine();
            int months = 6;
            double totalHoney = 0;
            bool isDone = false;

            while (command!= "Winter has come")
            {
                string nameBee = command;
                double honeyPerBee = 0;
                for (int i = 1; i <= months; i++)
                {
                    double producedHoney = double.Parse(Console.ReadLine());
                    if(producedHoney>0)
                    {
                        honeyPerBee += producedHoney;
                        
                    }
                    if(producedHoney<0)
                    {
                        honeyPerBee += producedHoney;
                    }
                }
                if(honeyPerBee<0)
                {
                    Console.WriteLine($"{nameBee} was banished for gluttony");
                    
                }
                totalHoney += honeyPerBee;
               
                if(reserveHoney<=totalHoney)
                {
                    isDone = true;
                    break;
                }
                command = Console.ReadLine();
            }

            if(isDone)
            {
                Console.WriteLine($"Well done! Honey surplus {totalHoney-reserveHoney:f2}.");
            }
            else
            {
                Console.WriteLine($"Hard Winter! Honey needed {reserveHoney-totalHoney:f2}.");
            }

        }
    }
}
