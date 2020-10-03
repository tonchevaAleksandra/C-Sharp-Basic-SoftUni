using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int weidth = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int cake = weidth * lenght;
            int eatedPieces = 0;
            int pieces = 0;
            string command = Console.ReadLine();
            while (command!="STOP" && cake>eatedPieces)
            {
                pieces = int.Parse(command);
                eatedPieces += pieces;
                if (eatedPieces > cake)
                {
                    break;
                }

                command = Console.ReadLine();
                if(command=="STOP")
                {
                    break;
                }
                
            }

            if(cake>eatedPieces)
            {
                Console.WriteLine($"{cake - eatedPieces} pieces are left.");
            }

            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cake-eatedPieces)} pieces more.");
            }
        }
    }
}
