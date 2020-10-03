using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string password = Console.ReadLine();
            string pass = "";
            while(pass != password)
            {
                pass = Console.ReadLine();
                if(pass==password)
                {
                    break;
                }
            }

            Console.WriteLine($"Welcome {name}!");

        }
    }
}
