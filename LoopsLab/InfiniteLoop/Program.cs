using System;

namespace InfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string username = "Aleks";
            while (name!=username)
            {
                Console.WriteLine("Wrong name");
                if(name==username)
                {
                    Console.WriteLine("Hello, {name}!");
                    break;
                }
            }
        }
    }
}
