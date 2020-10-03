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
                string currentNum = i.ToString();
                int oddSum = 0;
                int evenSum = 0;
                for (int j = 0; j < currentNum.Length; j++)
                {
                    if(j%2!=0)
                    {
                        evenSum += int.Parse(currentNum[j].ToString());
                    }
                    else
                    {
                        oddSum += int.Parse(currentNum[j].ToString());
                    }
                }
                if(oddSum==evenSum)
                {
                    Console.Write($"{i} ");
                }

            }
        }
    }
}
