using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();
            double totalGrades = 0.0;
            double countPresnt = 0;

            while (presentation!="Finish")
            {
                countPresnt++;
                double grades = 0;
                for (int i = 0; i < n; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    grades += grade;
                }
                totalGrades += grades;
                double averageGrades = grades / n * 1.0;
                Console.WriteLine($"{presentation} - {averageGrades:f2}.");
                presentation = Console.ReadLine();
            }
            double averageTotal = totalGrades /( n * countPresnt);
            Console.WriteLine($"Student's final assessment is {averageTotal:f2}.");
        }
    }
}
