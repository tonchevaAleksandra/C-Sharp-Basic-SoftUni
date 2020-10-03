using System;

namespace GraduationPart2
{
    class Program
    {
        static void Main(string[] args)
        {
        string name = Console.ReadLine();
        int counter = 1;
        int counterFail = 0;
        double sum = 0.0;
        while (counter <= 12 && counterFail<2)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade >= 4.00)
            {
                sum += grade;
                counter++;
            }
            else if (grade < 4.00)
            {
                counterFail++;
                continue;
            }
            if(counterFail==2)
            {
                break;
            }


        }
        if (counterFail < 2)
        {
            double averageGrade = sum / 12;
            Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
        }
        else
        {
            Console.WriteLine($"{name} has been excluded at {counter} grade");
        }
       
    }
    }
}
