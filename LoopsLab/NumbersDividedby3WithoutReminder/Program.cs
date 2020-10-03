using System;

namespace NumbersDividedby3WithoutReminder
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            while(num>0 && num<=100 )
            {
                if(num%3==0)
                {
                    Console.WriteLine(num);
                    num++;

                }
                else
                {
                    num++;
                }
               
            }
        }
    }
}
