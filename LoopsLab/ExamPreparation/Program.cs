using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowGrades = int.Parse(Console.ReadLine());
            
            
            int counterLowGrades = 0;
            int counter = 0;
            double sumGrade = 0.0;
            string lasTask = "";
            bool isFailed = true;
            while (counterLowGrades <lowGrades)
            {
                string task = Console.ReadLine();
                if (task == "Enough")
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());

                if (grade <= 4)
                {
                    counterLowGrades++;
                }
                sumGrade += grade;
                counter++;
                lasTask = task;
                
                
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {counterLowGrades} poor grades.");
                
            }
            
            else
            {
                Console.WriteLine($"Average score: {(sumGrade / counter):f2}");
                Console.WriteLine($"Number of problems: {counter}");
                Console.WriteLine($"Last problem: {lasTask}");
            }
           

                

        }
    }
}
