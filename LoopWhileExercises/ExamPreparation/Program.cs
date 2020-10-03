using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int counter = 0;
            string lastProblem = "";
            double totalGrades = 0.0;
            int counterBadGR = 0;
            while (command !="Enough" )
            {
                string problem = command;
                lastProblem = problem;
                int grade = int.Parse(Console.ReadLine());
                totalGrades += grade;
                if(grade<=4)
                {
                    counterBadGR++;
                }

                if(counterBadGR==badGrades)
                {
                    break;
                }

                counter++;
                command = Console.ReadLine();
            }

            if(command=="Enough")
            {
                double average = totalGrades / counter;
                Console.WriteLine($"Average score: {average:f2}");
                Console.WriteLine($"Number of problems: {counter}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }

            if(counterBadGR == badGrades)
            {
                Console.WriteLine($"You need a break, {counterBadGR} poor grades.");
            }

        }
    }
}
