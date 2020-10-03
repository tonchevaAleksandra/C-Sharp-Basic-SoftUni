using System;

namespace ScholarShip
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());
            double socialScholarShip = 0.35 * minSalary;
            double excellentResult = averageGrade * 25;


            if (income < minSalary && averageGrade > 4.5 && averageGrade < 5.5)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarShip)} BGN");
            }
            else if (averageGrade >= 5.5)
            {
                if (income < minSalary && socialScholarShip > excellentResult)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarShip)} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentResult)} BGN");
                }

            }
            else
            {
                Console.WriteLine($"You cannot get a scholarship!");
            }
        }
    }
}
