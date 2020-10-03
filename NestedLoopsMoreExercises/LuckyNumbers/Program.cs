using System;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumFS = 0;
            int sumTF = 0;

            for (int firstNum = 1; firstNum <=9; firstNum++)
            {
                for (int secondNum = 1; secondNum <=9; secondNum++)
                {
                    for (int thirdNum = 1; thirdNum <=9; thirdNum++)
                    {
                        for (int fourthNum = 1; fourthNum <= 9; fourthNum++)
                        {
                            sumFS = firstNum + secondNum;
                            sumTF = thirdNum + fourthNum;
                            if(sumFS==sumTF && n%sumFS==0)
                            {
                                Console.Write($"{firstNum}{secondNum}{thirdNum}{fourthNum} ");
                            }

                        }
                    }
                }
            }
        }
    }
}
