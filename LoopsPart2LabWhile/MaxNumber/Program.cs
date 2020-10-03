using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            while (n!=0)
            {
                int number = int.Parse(Console.ReadLine());
                if(number>maxNum)
                {
                    maxNum = number;
                }

                n--;
            }
            Console.WriteLine(maxNum);
        }
    }
}
