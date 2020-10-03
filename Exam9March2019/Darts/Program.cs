using System;

namespace Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Първоначално се чете един ред:
            //• Името на играча - текст
            //След това до получаване на команда "Retire" се четат многократно по два реда:
            //1.Поле – текст("Single", "Double" или "Triple")
            //2.Точки – цяло число в интервала[0… 100]
            //Изход
            //Играта приключва при въвеждане на команда "Retire" или при изравняване на началните 301 точки към 0.
            //На конзолата трябва да се напечата един ред:
            //• Ако играчът е спечелил лега:
            //            o "{името на играча} won the leg with {успешните изстрели} shots."
            //• Ако играчът се е отказал от играта:
            //            o "{името на играча} retired after {неуспешни изстрели} unsuccessful shots."

            string name = Console.ReadLine();
            string command = Console.ReadLine();
            int totalPoints = 301;
            int counter = 0;
            int counterFailled = 0;
            
            while (command != "Retire" && totalPoints !=0)
            {
                string field = command;
                int points = int.Parse(Console.ReadLine());
                
                if(field=="Single")
                {
                    points = points *1;
                    totalPoints -= points;
                    counter += 1;
                }
                else if(field=="Double")
                {
                    points= points * 2;
                    totalPoints -= points;
                    counter += 1;
                }
                else
                {
                    points = points * 3;
                    totalPoints -= points;
                    counter += 1;
                }
                if (totalPoints == 0)
                {
                    break;
                }
                if (totalPoints<0)
                {
                    counterFailled +=1;
                   totalPoints= totalPoints + points;
                    counter -= 1;
                }
                
               
                command = Console.ReadLine();
               
            }
            if(command=="Retire")
            {

                Console.WriteLine($"{name} retired after {counterFailled} unsuccessful shots.");
            }
            if(totalPoints==0)
            {
                Console.WriteLine($"{name} won the leg with {counter} shots.");
            }
        }
    }
}

