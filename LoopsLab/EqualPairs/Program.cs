using System;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дадени са 2 * n - на брой числа. Първото и второто формират двойка, третото и четвъртото също и т.н.Всяка двойка има стойност – сумата от съставящите я числа.Напишете програма, която проверява дали всички двойки имат еднаква стойност или печата максималната разлика между две последователни двойки.Ако
            //всички двойки имат еднаква стойност, отпечатайте "Yes, value = {Value}" + стойността.В противен случай отпечатайте "No, maxdiff = {Difference}" + максималната разлика.
            int n = int.Parse(Console.ReadLine());

            double sum = 0;
            double difference = 0;
            double maxDifference = 0;

            for (int i = 0; i < n; i++)
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                double currentSum = num1 + num2;
                if (i == 0)
                {
                    sum = currentSum;
                }
                else
                {
                    difference = Math.Abs(sum - currentSum);
                    sum = currentSum;
                }
                if (difference > maxDifference)
                {
                    maxDifference = difference;
                }
            }
            if (maxDifference == 0)
            {
                Console.WriteLine($"Yes, value={sum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDifference}");
            }

        }
    }
}
