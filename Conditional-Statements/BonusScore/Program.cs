using System;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double bonus = 0.0;
            if (num<=100)
            {
                bonus = 5;
                    }
            if (num > 100)
            {
                bonus = 0.2 * num;
            }
           if (num > 1000)
                    {
                bonus = 0.1 * num;
            }
           if(num%2==0)
            {
                bonus = bonus + 1;
            }
           else if(num%5==0)
            {
                bonus = bonus + 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(bonus + num);

        }
    }
}
