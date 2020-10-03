using System;

namespace Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Първи ред – държава – текст ("Russia", "Bulgaria" или "Italy")
            //• Втори ред – уред - текст("ribbon", "hoop" или "rope")
            string country = Console.ReadLine();
            string device = Console.ReadLine();
            double difficulty = 0.0;
            double performance = 0.0;
            double totalNote = 0.0;
            double percent = 0.0;
            if(device=="ribbon")
            {
                if(country=="Russia")
                {
                    difficulty = 9.100; performance = 9.400; totalNote = difficulty + performance;
                }
                else if (country == "Bulgaria")
                {
                    difficulty = 9.600; performance = 9.400; totalNote = difficulty + performance;
                }
                else if (country == "Italy")
                {
                    difficulty = 9.200; performance = 9.500; totalNote = difficulty + performance;
                }
            }
            else if (device == "hoop")
            {
                if (country == "Russia")
                {
                    difficulty = 9.300; performance = 9.800; totalNote = difficulty + performance;
                }
                else if (country == "Bulgaria")
                {
                    difficulty = 9.550; performance = 9.750; totalNote = difficulty + performance;
                }
                else if (country == "Italy")
                {
                    difficulty = 9.450; performance = 9.350; totalNote = difficulty + performance;
                }
            }
            else if (device == "rope")
            {
                if (country == "Russia")
                {
                    difficulty = 9.600; performance = 9.000; totalNote = difficulty + performance;
                }
                else if (country == "Bulgaria")
                {
                    difficulty = 9.500; performance = 9.400; totalNote = difficulty + performance;
                }
                else if (country == "Italy")
                {
                    difficulty = 9.700; performance = 9.150; totalNote = difficulty + performance;
                }
            }
            percent = ((20 - totalNote) / 20) * 100;
            Console.WriteLine($"The team of {country} get {totalNote:f3} on {device}.");
            Console.WriteLine($"{percent:f2}%");


        }
    }
}
