using System;

namespace MetricConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();
            if (input == "m" && output=="cm")
            {
                Console.WriteLine($"{num * 100:F3}");
            }
            else if(input=="m"&& output=="mm")
            {
                Console.WriteLine($"{num * 1000:f3}");
            }
            else if(input=="cm" && output=="m")
            {
                Console.WriteLine($"{num / 100:f3}");
            }
            else if(input=="cm" && output=="mm")
            {
                Console.WriteLine($"{num * 10:f3}");
            }
            else if(input=="mm" && output=="cm")
            {
                Console.WriteLine($"{num / 10:f3}");
            }
            else if(input=="mm" && output=="m")
            {
                Console.WriteLine($"{num / 1000:f3}");
            }

        }
    }
}
