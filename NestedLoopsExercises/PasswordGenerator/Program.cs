using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int first = 1; first <= n; first++)
            {
                for (int second = 1; second <= n; second++)
                {
                    for (int third = 'a'; third < 'a' + l; third++)
                    {
                        //for(char third ='a';third< 'a' + l;third++)
                        //Console.Write({third});
                        for (int fourth = 'a'; fourth < 'a' + l; fourth++)
                        {
                            int maxNum = Math.Max(first, second);
                            for (int fifth = maxNum + 1; fifth <= n; fifth++)
                            {
                                Console.Write($"{first}{second}{(char)third}{(char)fourth}{fifth} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
