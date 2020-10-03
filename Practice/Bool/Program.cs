using System;

namespace Bool
{
    class Program
    {
        static void Main(string[] args)
        {
           string name = Console.ReadLine();
            switch (name)
            {
                case "Georgi":
                case "Atanas":
                case "Alex":
                    Console.WriteLine($"The name is{name}");break;
                default: Console.WriteLine("False");break;
            }
           
        }
    }
}
