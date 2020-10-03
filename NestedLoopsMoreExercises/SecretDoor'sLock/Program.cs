using System;

namespace SecretDoor_sLock
{
    class Program
    {
        static void Main(string[] args)
        {
            //            От конзолата се четат 3 реда:
            //•	Горната граница на стотиците -цяло число в диапазона(1 - 9)
            //•	Горната граница на десетиците -цяло число в диапазона(1 - 9)
            //•	Горната граница на единиците -цяло число в диапазона(1 - 9)

            int end100 = int.Parse(Console.ReadLine());
            int end10 = int.Parse(Console.ReadLine());
            int end1 = int.Parse(Console.ReadLine());

            for (int i = 2; i <= end100; i++)
            {
                if(i%2==0)
                {
                    for (int j = 2; j <= end10; j++)
                    {
                        if(j%2 !=0 && j%3!=0 || j==2 || j==3)
                        {
                            for (int k = 2; k <= end1; k++)
                            {
                                if(k%2==0)
                                {
                                    Console.WriteLine($"{i} {j} {k}");
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
