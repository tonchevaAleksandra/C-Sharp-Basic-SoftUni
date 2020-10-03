using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();
            double totalGrades = 0;
            int counterPresen = 0;
            while (presentation !="Finish")
            {
                double gradesPerPres = 0;
                counterPresen++;
                for (int i = 0; i < n; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    gradesPerPres += grade;
                }

                Console.WriteLine($"{presentation} - {gradesPerPres/n:f2}.");

                totalGrades += gradesPerPres;
                presentation = Console.ReadLine();
            }

            if(presentation=="Finish")
            {
                Console.WriteLine($"Student's final assessment is {totalGrades / (counterPresen * n * 1.00):f2}.");
            }
           
        }
    }
}
