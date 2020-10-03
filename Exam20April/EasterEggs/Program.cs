using System;

namespace EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            //• Броят на боядисаните яйца – цяло число в интервала[1... 100]
            //За всяко яйце се чете:
            //o Цветът на яйцето – текст с възможности: "red", "orange", "blue", "green"
            int eggs = int.Parse(Console.ReadLine());
            int redEggs = 0;
            int orangeEggs = 0;
            int blueEggs = 0;
            int greenEggs = 0;
            int maxEggs = 0;
            string colorMax = "";
            for (int i = 0; i < eggs; i++)
            {
                string color = Console.ReadLine();
                switch (color)
                {
                    case "red":
                        redEggs++;
                        if (redEggs > maxEggs) { maxEggs = redEggs; colorMax = "red"; }
                        break;
                    case "orange":
                        orangeEggs++;
                        if (orangeEggs > maxEggs) { maxEggs = orangeEggs; colorMax = "orange"; }
                        break;
                    case "blue":
                        blueEggs++;
                        if (blueEggs > maxEggs) { maxEggs = blueEggs; colorMax = "blue"; }
                        break;
                    case "green":
                        greenEggs++;
                        if (greenEggs > maxEggs) { maxEggs = greenEggs; colorMax = "green"; }
                        break;

                }
            }
            Console.WriteLine($"Red eggs: {redEggs}");
            Console.WriteLine($"Orange eggs: {orangeEggs}");
            Console.WriteLine($"Blue eggs: {blueEggs}");
            Console.WriteLine($"Green eggs: {greenEggs}");
            Console.WriteLine($"Max eggs: {maxEggs} -> {colorMax}");

        }
    }
}




