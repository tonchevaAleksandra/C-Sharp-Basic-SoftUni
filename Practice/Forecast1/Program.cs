using System;

namespace Forecast1
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = (Console.ReadLine());
            if( word == "sunny") { Console.WriteLine($"It's warm outside!"); }
            else { Console.WriteLine($"It's cold outside!"); }
        }
    }
}
