using System;

namespace GeorgisQuizGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.Title = "Quiz";

            bool isSelected = false;

            int selected = 1;
            int optionsCount = 10;
            while (!isSelected)
            {
                for (int i = 1; i <= optionsCount; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (selected == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("=> ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }

                    Console.WriteLine(i);
                    Console.ResetColor();
                }

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        if (selected == 1)
                        {
                            selected = optionsCount;
                        }
                        else
                        {
                            selected -= 1;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        if (selected == optionsCount)
                        {
                            selected = 1;
                        }
                        else
                        {
                            selected += 1;
                        }
                        break;
                    case ConsoleKey.Enter:
                    case ConsoleKey.F:
                        isSelected = true;
                        break;
                }

                if (!isSelected)
                    Console.CursorTop -= optionsCount;
            }

            Console.WriteLine();
            Console.WriteLine($"Selected {selected}.");
        }
    }
}
