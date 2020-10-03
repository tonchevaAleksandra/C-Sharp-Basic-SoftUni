using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int count = int.Parse(Console.ReadLine());
            double number = 0.0;
            int counter = 0;
            double sum = 0.0;
            
            while (counter<count)
            {
                num = int.Parse(Console.ReadLine());
                number = Convert.ToDouble(num);
                sum += number;
                counter++;
                
            }
               
            if(counter==count)
            {
                Console.WriteLine($"{sum / count:f2}");
            }
           
        }
    }
}
