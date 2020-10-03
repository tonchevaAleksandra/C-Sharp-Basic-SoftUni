using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = 10000;
            int steps = 0;
            int totalSteps = 0;

            while (totalSteps < goal)
            {
                string input = Console.ReadLine();

                if (input == "Going home")
                {
                    int lastSteps = int.Parse(Console.ReadLine());
                    totalSteps += lastSteps;
                    break;
                }
                steps = int.Parse(input);
                totalSteps += steps;
            }
            if (totalSteps >= goal)
            {
                Console.WriteLine($"Goal reached! Good job!");
            }
            else
            {
                Console.WriteLine($"{goal - totalSteps} more steps to reach goal.");
            }
        }
    }
}






