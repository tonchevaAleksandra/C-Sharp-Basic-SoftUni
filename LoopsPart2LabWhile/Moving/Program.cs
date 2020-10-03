using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int weidth = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int freeSpace = weidth * lenght * height;
            int totalBoxes = 0;
            string command = Console.ReadLine();
            while (command !="Done" && freeSpace >=totalBoxes)
            {
                int boxes = int.Parse(command);
                
               

                    totalBoxes += boxes;
                command = Console.ReadLine();
            }

            if(command=="Done")
            {
                Console.WriteLine($"{freeSpace - totalBoxes} Cubic meters left.");
            }
            if (totalBoxes > freeSpace)
            {
                Console.WriteLine($"No more free space! You need {totalBoxes - freeSpace} Cubic meters more.");
                
            }

        }
    }
}
