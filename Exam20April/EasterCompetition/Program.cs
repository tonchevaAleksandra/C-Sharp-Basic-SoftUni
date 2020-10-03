using System;

namespace EasterCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBreads = int.Parse(Console.ReadLine());
            int maxGrade = int.MinValue;
            string currentCook = "";
            string winner = "";
            int winnerPoints = 0;
            for (int i = 1; i <= easterBreads; i++)
            {
                string nameCook = Console.ReadLine();
                currentCook = nameCook;
                int totalGrades = 0;
                string command = Console.ReadLine();
                while (command != "Stop")
                {
                    
                    int gradePerCook = int.Parse(command);
                    totalGrades += gradePerCook;

                    command = Console.ReadLine();
                }
                if(totalGrades>winnerPoints)
                {
                    winner = currentCook;
                    winnerPoints = totalGrades;
                }
                if (command == "Stop")
                {
                    Console.WriteLine($"{currentCook} has {totalGrades} points.");
                    if (totalGrades > maxGrade)
                    {
                        maxGrade = totalGrades;
                        Console.WriteLine($"{currentCook} is the new number 1!");
                    }
                    
                }

            }

            Console.WriteLine($"{winner} won competition with {winnerPoints} points!");
        }
    }
}
