using System;

namespace HighJump
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Входът е поредица от цели числа в интервала[100…300]:
            //• На първия ред се прочита желаната от Тихомир Иванов височина в сантиметри
            //• На всеки следващ ред до приключване на програмата се прочита височината от скока на Иванов

            int wantedHight = int.Parse(Console.ReadLine());
            int counterJumps = 0;
            int currentSm = 0;
            int failTimes = 0;
            bool stop = false;

            for (int i = wantedHight - 30; i <= wantedHight; i+=5)
            {
                
                for (int j = 1; j <=3; j++)
                {
                    int currentheight = int.Parse(Console.ReadLine());
                    counterJumps++;
                    
                    if (currentheight > i)
                    {
                         failTimes = 0;
                        break;

                    }
                    else
                    {
                        failTimes += 1;

                    }
                    currentSm = currentheight;


                }
                if (failTimes == 3)
                {
                    Console.WriteLine($"Tihomir failed at {currentSm}cm after {counterJumps} jumps.");
                    return;
                }

               
            }
            
            if (!stop)
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {wantedHight}cm after {counterJumps} jumps.");
            }
  
        }
    }
}
