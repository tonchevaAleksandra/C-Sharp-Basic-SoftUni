
using System;


namespace Exam_Preperation
{
    class Program
    {
        static void Main(string[] args)
        {

            double BadGradesCount = double.Parse(Console.ReadLine());
            string TaskName = Console.ReadLine();
            string LastTaskName = "";
            double CounterProblems = 0;
            double counterBadGrades = 0;
            double GradesCounter = 0;
            bool IsEnought = false;
            while (!IsEnought)
            {
                double Grades = double.Parse(Console.ReadLine());
                CounterProblems++;
                LastTaskName = TaskName;
                if (Grades <= 4)
                {
                    counterBadGrades++;
                    if (counterBadGrades >= BadGradesCount)
                    {
                        Console.WriteLine($"You need a break, {counterBadGrades} poor grades.");
                        break;
                    }
                }
                TaskName = Console.ReadLine();
                if (TaskName == "Enought")
                {
                    IsEnought = true;
                }
                GradesCounter += Grades;
            }
            if (IsEnought)
            {
                Console.WriteLine($"Average score: {GradesCounter / CounterProblems:F2}");
                Console.WriteLine($"Number of problems: {CounterProblems}");
                Console.WriteLine($"Last problem: { LastTaskName}");
            }
        }
    }
}


