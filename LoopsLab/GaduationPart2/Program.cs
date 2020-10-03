using System;

namespace GaduationPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double sum = 0.0;
            int counter = 1;
            int count = 0;
            bool isExcluded = false;
            while (counter<=12)
            {
                double grade = double.Parse(Console.ReadLine());
                if(grade>=4.00)
                {
                    sum += grade;
                    counter++;
                }
                else if(grade < 4.00)
                {
                    count++;
                }
                if(count>=2)
                {
                    isExcluded = true;
                    break;
                }
            }
            if (isExcluded == false)
            {
                double averageGrade = sum / 12;
                Console.WriteLine($"{name} graduated. Average grade: { averageGrade:f2}");
            }
                    
             else
            {
                Console.WriteLine($"{name} has been excluded at {counter} grade ");
            }
           


        }
    }
}
