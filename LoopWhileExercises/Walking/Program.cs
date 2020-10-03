using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = 10000;
            
            int totalSteps = 0;
            while (totalSteps<goal)

            {
                string command = Console.ReadLine();
                if (command == "Going home")
                {
                   int lastSteps = int.Parse(Console.ReadLine());
                    totalSteps += lastSteps;
                    break;

                }
                int currentSteps = int.Parse(command);

                totalSteps += currentSteps;

            }

            if ( totalSteps<goal)
            {
                Console.WriteLine($"{goal - totalSteps} more steps to reach goal.");
            }
            else
            {
                Console.WriteLine($"Goal reached! Good job!");
            }
        }
    }
}
