using System;

namespace MovieTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int first = a1; first <= a2 - 1; first++)
            {
                if (first % 2 != 0)
                {
                    for (int second = 1; second <= n - 1; second++)
                    {
                        for (int third = 1; third <= n / 2 - 1; third++)
                        {
                            int sum = second + third + first;
                            if (sum % 2 != 0)
                            {
                                char firstSymbol = (char)first;
                                Console.WriteLine($"{firstSymbol}-{second}{third}{first}");
                            }
                        }
                    }
                }
            }
        }
    }
}
