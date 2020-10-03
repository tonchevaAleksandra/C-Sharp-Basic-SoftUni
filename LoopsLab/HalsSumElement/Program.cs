using System;

namespace HalsSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете n-на брой цели числа, въведени от потребителя, и проверява дали сред
            //тях съществува число, което е равно на сумата на всички останали. Ако има такъв елемент, печата &quot; Yes & quot;, &quot; Sum
            //  = &quot; +неговата стойност; иначе печата &quot; No & quot;, &quot; Diff = &quot; +разликата между най-големия елемент и сумата на
            ////останалите(по абсолютна стойност).
           
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;
            
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
                
                if (number>max )
                {
                    max = number;
                }

            }
            int sumWithoutMaxNumber = sum - max;
            if(max==sumWithoutMaxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                int diff = Math.Abs(max - sumWithoutMaxNumber);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
           


        }
    }
}
