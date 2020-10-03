using System;

namespace TheSongOftheWheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int w = 0;
            int x = 0;
            int y = 0;
            int z = 0;
            int counter = 0;
            bool isFound = false;
            //m=a*b+c*d  end a < b && c > d 
            //the fouth number is the password

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if(a < b && c > d && (a*b+c*d==m))
                            {
                                Console.Write($"{a}{b}{c}{d} ");
                                counter += 1;
                                if (counter == 4)
                                {
                                    w = a; x = b;
                                    y = c; z = d;
                                    isFound = true;
                                }
                            }
                       
                        }
                    }
                }
            }
            Console.WriteLine();
            if(isFound)
            {
                Console.WriteLine($"Password: {w}{x}{y}{z}");
            }
            if (!isFound)
            {
                Console.WriteLine("No!");
            }

        }
    }
}
