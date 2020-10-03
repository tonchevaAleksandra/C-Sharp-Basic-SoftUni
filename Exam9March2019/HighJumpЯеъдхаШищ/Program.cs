using System;

namespace HighJumpSecondTry
{
    class Program
    {
        static void Main(string[] args)
        {
            int wantedHeight = int.Parse(Console.ReadLine());
            int countJumps = 0;
           

            for (int i = wantedHeight-30; i <= wantedHeight; i+=5)
            {
                int counterFailed = 0;
                int currentHeight = int.Parse(Console.ReadLine());
                countJumps++;
                if (currentHeight>wantedHeight && i==wantedHeight)
                {
                    Console.WriteLine($"Tihomir succeeded, he jumped over {i}cm after {countJumps} jumps.");
                    break;
                }
                else if(currentHeight > wantedHeight)
                {
                    continue;
                }
                
                if(currentHeight>i)
                {

                   continue;
                }
                else
                {
                    counterFailed++;
                    while (counterFailed < 3)
                    { 
                        currentHeight = int.Parse(Console.ReadLine());
                        countJumps++;
                        if (currentHeight > wantedHeight && i == wantedHeight)
                        {
                            Console.WriteLine($"Tihomir succeeded, he jumped over {wantedHeight}cm after {countJumps} jumps.");
                            return;
                           
                        }
                        else if (currentHeight > wantedHeight)
                        {
                            break;
                        }
                        if (currentHeight > i)
                        {
                            break;
                        }
                        else 
                        { 
                            counterFailed++; 
                        }
                    }
                }
                if(counterFailed==3)
                {
                    Console.WriteLine($"Tihomir failed at {i}cm after {countJumps} jumps.");
                    break;
                }

            }

            
        }
    }
}
