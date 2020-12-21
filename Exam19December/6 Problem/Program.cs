using System;

namespace _6_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            //•	K - началото на интервала за първото число от първия номер – цяло число в интервала [0..8]

            int l = int.Parse(Console.ReadLine());
            //•	L - началото на интервала за второто число от първия номер – цяло число в интервала [9..0]

            int m = int.Parse(Console.ReadLine());
            //•	M - началото на интервала за първото число от втория номер – цяло число в интервала [0..8]

            int n = int.Parse(Console.ReadLine());
            //•	N - началото на интервала за второто число от втория номер – цяло число в интервала [9..0]
            int finishFirstNum = 8;
            int startSecondNum = 9;

            int finishFirstDigitSecondNum = 8;
            int startSecondDigitSecondNum = 9;
            int counter = 0;
           while(counter<=6)
            {

               while(k<=8 && startSecondNum>=0)
                {
                    while (m <= 8)
                    {
                        if (k % 2 == 0 && startSecondNum % 2 != 0 && m % 2 == 0 && startSecondDigitSecondNum % 2 != 0)
                        {
                            Console.WriteLine($"{k}{startSecondNum} - {m}{startSecondDigitSecondNum}");
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine($"Cannot change the same player.");
                           
                        }
                        if(counter==6)
                        {
                            break;
                        }
                        startSecondDigitSecondNum--;
                        if(startSecondDigitSecondNum<0)
                        {
                            m++;
                            startSecondDigitSecondNum = 9;
                        }
                    }
                   

                }
              if(counter==6)
                {
                    break;
                }
              

            

            }

        }
    }
}
