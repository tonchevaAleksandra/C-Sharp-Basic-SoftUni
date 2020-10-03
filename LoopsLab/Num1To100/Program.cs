using System;

namespace Num1To100
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            while (a < 1 || a > 100)
            {
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(a);
        }
    }
}
