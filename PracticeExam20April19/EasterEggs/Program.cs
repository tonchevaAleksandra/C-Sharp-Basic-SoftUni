using System;

namespace EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            //           • Броят на боядисаните яйца – цяло число в интервала[1... 100]
            //За всяко яйце се чете:
            //            o Цветът на яйцето – текст с възможности: "red", "orange", "blue", "green"
            int cntEggs = int.Parse(Console.ReadLine());
            int maxEggs = 0;
            string maxColor = "";
            int cntRed = 0;
            int cntOrange = 0;
            int cntBlue = 0;
            int cntGreen = 0;

            for (int i = 0; i < cntEggs; i++)
            {
                string color = Console.ReadLine();
                switch (color)
                {
                    case "red":
                        cntRed++;
                        break;
                    case "orange":
                        cntOrange++;
                        break;
                    case "blue":
                        cntBlue++;
                        break;
                    case "green":
                        cntGreen++;
                        break;
                }

            }
            if (cntRed>maxEggs)
            {
                maxEggs = cntRed;
                maxColor = "red";
            }
            if(cntOrange>maxEggs)
            {
                maxEggs = cntOrange;
                maxColor = "orange";
            }
            if(cntBlue>maxEggs)
            {
                maxEggs = cntBlue;
                maxColor = "blue";
            }
            if(cntGreen>maxEggs)
            {
                maxEggs = cntGreen;
                maxColor = "green";
            }
            Console.WriteLine($"Red eggs: {cntRed}");
            Console.WriteLine($"Orange eggs: {cntOrange}");
            Console.WriteLine($"Blue eggs: {cntBlue}");
            Console.WriteLine($"Green eggs: {cntGreen}");
            Console.WriteLine($"Max eggs: {maxEggs} -> {maxColor}");
        }
    }
}
