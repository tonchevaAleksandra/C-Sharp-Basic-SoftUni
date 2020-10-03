using System;

namespace UniquePINCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstMark = int.Parse(Console.ReadLine());
            int secondMark = int.Parse(Console.ReadLine());
            int thirdMark = int.Parse(Console.ReadLine());

            for (int firtNum = 1; firtNum <= firstMark; firtNum++)
            {
                if (firtNum % 2 == 0)
                {
                    for (int secondNum = 2; secondNum <= secondMark; secondNum++)
                    {
                        if (secondNum % 2 != 0 && secondNum % 3 != 0 || secondNum == 2 ||secondNum==3)

                        {
                            for (int thirdNum = 1; thirdNum <= thirdMark; thirdNum++)
                            {
                                if (thirdNum % 2 == 0)
                                {
                                    Console.WriteLine($"{firtNum} {secondNum} {thirdNum}");
                                }
                            }
                        }
                     
                    }
                }
            }
        }
    }
}
                        




