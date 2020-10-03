using System;

namespace SafePasswordsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //ABxyBA

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxGeneratedPass = int.Parse(Console.ReadLine());

            int counterPass = 0;

            for (char first = '#'; first <= 55; first++)
            {
                for (char second = '@'; second < 96; second++)
                {
                    for (int third = 1; third <= a; third++)
                    {
                        for (int fourth = 1; fourth <= b; fourth++)
                        {
                            Console.Write($"{first}{second}{third}{fourth}{second}{first}|");

                            counterPass+=1;
                            first++;
                            second++;
                            if (first >55)
                            {
                                first = '#';
                            }
                            if (second > 96)
                            {
                                second = '@';
                            }
                            if (counterPass >= maxGeneratedPass)
                            {
                                break;
                            }
                            if (fourth == b && third==a)
                            {
                                return;
                            }

                        }
                        if (counterPass >= maxGeneratedPass)
                        {
                            break;
                        }
                    }
                    if (counterPass >= maxGeneratedPass)
                    {
                        break;
                    }

                }
                if (counterPass >= maxGeneratedPass)
                {
                   return;
                }

               
            }

        }
    }
}







