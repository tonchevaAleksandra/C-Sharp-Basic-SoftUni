using System;

namespace _4.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());

            int toStudentsCount = 0;
            int studentsCountBetween4And5 = 0;
            int studentsCountBetween3And4 = 0;
            int failedStudents = 0;

            double totalGrades = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 5.00)
                {
                    toStudentsCount++;
                }
                else if (grade >= 4.00 && grade < 5.00)
                {
                    studentsCountBetween4And5++;
                }
                else if (grade >= 3.00 && grade < 4.00)
                {
                    studentsCountBetween3And4++;
                }
                else
                {
                    failedStudents++;
                }

                totalGrades += grade;
            }

            double percentTopStudents = (toStudentsCount * 1.00 / studentsCount) * 100;
            double percentSecondGroup = (studentsCountBetween4And5 * 1.00 / studentsCount) * 100;

            double percentThirdGroup = (studentsCountBetween3And4 * 1.00 / studentsCount) * 100;

            double percentFailedGroup = (failedStudents * 1.00 / studentsCount) * 100;


            double averageGrade = totalGrades / studentsCount;

            Console.WriteLine($"Top students: {percentTopStudents:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {percentSecondGroup:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {percentThirdGroup:F2}%");
            Console.WriteLine($"Fail: {percentFailedGroup:F2}%");

            Console.WriteLine($"Average: {averageGrade:F2}");
        }
    }
}
