using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            
            double sum = 0;
            int counter = 0;

            while (counter<12)
            {
                double grade = double.Parse(Console.ReadLine());
                if(grade>=4.00)
                {
                    sum += grade;
                    counter++;
                }
                
            }
            double averageGrade = sum /12;
            Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");


        }
    }
}
