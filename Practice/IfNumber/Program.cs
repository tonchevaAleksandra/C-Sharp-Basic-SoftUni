using System;

namespace IfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if(number < 10){ Console.WriteLine("Number is lower than 10");}
                else if (number == 10) { Console.WriteLine("Number is 10");}
                else { Console.WriteLine("Number is bigger than 10"); }

               
               
            }
        }
    }

