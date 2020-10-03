using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //break all loops
            //count combination number
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int counter = 0;
            bool isFound = false;
            for (int num1 = start; num1 <= end; num1++)
            {
                for (int num2 = start; num2 <= end; num2++)
                {
                    counter++;
                    int sum = num1 + num2;
                    if(sum==magicNum)
                    {
                        Console.WriteLine($"Combination N:{counter} ({num1} + {num2} = {magicNum})");
                        isFound = true;
                        break;
                    }

                }
                if (isFound)
                {
                    break;
                }

            }

            if(!isFound)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            }
        }
    }
}
