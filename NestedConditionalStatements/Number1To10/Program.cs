using System;

namespace Number1To10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while ( num<=10)
            {
                Console.WriteLine($"{num++}");
            }
        }
    }
}
