using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Facebook  150 лв.
            // Instagram  100 лв.
            // Reddit  50 лв.
            //input n count open tabs
            // input salary
            int n = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string tab = Console.ReadLine();
                if(tab=="Facebook")
                {
                    salary -= 150;
                }
                else if(tab=="Instagram")
                {
                    salary -= 100;
                }
                else if(tab== "Reddit")
                {
                    salary -= 50;
                }
                else
                {
                    salary =1* salary;
                }
                if(salary<=0)
                {
                    Console.WriteLine($"You have lost your salary.");
                    break;
                }
            }
            if (salary > 0)
            { 
                Console.WriteLine($"{Convert.ToInt32(salary)}");
            }

        }
    }
}
