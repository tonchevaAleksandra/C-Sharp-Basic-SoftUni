using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int cntCombinations = 0;
            bool isFound = false;

            for (int i = start; i <=end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    cntCombinations++;
                    if (i+j==magicNum)
                    {
                        isFound = true;
                        Console.WriteLine($"Combination N:{cntCombinations} ({i} + {j} = {magicNum})");
                        break;
                    }
                    
                }
                if(isFound)
                {
                    break;
                }
            }

            if(!isFound)
            {
                Console.WriteLine($"{cntCombinations} combinations - neither equals {magicNum}");
            }
        }
    }
}
