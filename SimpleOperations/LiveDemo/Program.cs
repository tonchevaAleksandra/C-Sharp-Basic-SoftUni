using System;

namespace LiveDemo
{
    class Program
    {
        static void Main()
        {

            double number = 5.45000 ;
            double rounded = Math.Round(number, 4);
            string formated = $"{number:f4}";
            Console.WriteLine(rounded);
            Console.WriteLine(formated);
            
                
        }
    }
}
