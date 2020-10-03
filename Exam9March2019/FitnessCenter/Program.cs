using System;

namespace FitnessCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Вход
            //От конзолата се чете число, след това поредица от низове, всяко на отделен ред:
            //• На първия ред – броят на посетителите във фитнеса – цяло число в интервала[1...1000]
            //• За всеки един посетител на отделен ред – дейността във фитнеса – текст("Back", "Chest", "Legs", "Abs",
            //"Protein shake" или "Protein bar")
            int clients = int.Parse(Console.ReadLine());
            double countBack = 0;
            double countChest =0;
            double countLegs = 0;
            double countAbs = 0;
            double countShake = 0;
            double countBar = 0;
            for (int i = 0; i < clients; i++)
            {
                string activity = Console.ReadLine();
                switch (activity)
                {
                    case "Back": countBack++;
                        break;
                    case "Chest":countChest++;
                        break;

                    case "Legs":countLegs++;
                        break;
                    case "Abs":
                        countAbs++;
                        break;
                    case "Protein shake":
                        countShake++;
                        break;
                    case "Protein bar":
                        countBar++;
                        break;
                    
                   
                }
            }
            Console.WriteLine($"{countBack} - back");
            Console.WriteLine($"{countChest} - chest");
            Console.WriteLine($"{countLegs} - legs");
            Console.WriteLine($"{countAbs} - abs");
            Console.WriteLine($"{countShake} - protein shake");
            Console.WriteLine($"{countBar} - protein bar");
            double persentWOut = (countBack + countChest + countLegs + countAbs) / clients * 100.00;
            double persentProtein = (countShake + countBar) / clients * 100.00;
            Console.WriteLine($"{persentWOut:f2}% - work out");
            Console.WriteLine($"{persentProtein:f2}% - protein");
        }
    }
}
