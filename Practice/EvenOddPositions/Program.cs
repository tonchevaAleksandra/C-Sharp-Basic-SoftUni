using System;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                string currNum = i + "";
                int oddSum = 0;
                int evenSum = 0;
                string result = "";

                
                for (int j = 0; j < currNum.Length; j++)
                {
                    int currDigit = int.Parse(currNum[j].ToString());
                    if ((j + 1) % 2 == 0)
                    {
                        evenSum += currDigit;
                    }
                    else
                    {
                        oddSum += currDigit;
                    }
                }
                if (oddSum == evenSum)
                {
                    result += i + " ";
                    Console.Write($"{result}");
                }
                
            }
        }
    }
}