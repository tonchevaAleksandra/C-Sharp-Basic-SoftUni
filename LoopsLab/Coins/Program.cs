using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
           double rest = input*100;
            int counter = 0;

            while (rest>=1.0)
            {
                if(rest-200.0>=0.0)
                {
                    rest -= 200.0;
                    counter++;
                }
                else if(rest-100.0>=0.0)
                {
                    rest -= 100.0;
                    counter++;
                }
                else if(rest-50.0>=0.0)
                {
                    rest -= 50.0;
                    counter++;
                }
                else if(rest-20.0>=0.0)
                {
                    rest -= 20.0;
                    counter++;
                }
                else if(rest-10.0>=0.0)
                {
                    rest -= 10.0;
                    counter++;
                }
                else if(rest-5.0>=0.0)
                {
                    rest -= 5.0;
                    counter++;
                }
                else if(rest-2.0>=0.0)
                {
                    rest -= 2.0;
                    counter++;
                }
                else if(rest-1.0>=0.0)
                {
                    rest -= 1.0;
                    counter++;
                }
            }
            Console.WriteLine(counter);

        }
    }
}
