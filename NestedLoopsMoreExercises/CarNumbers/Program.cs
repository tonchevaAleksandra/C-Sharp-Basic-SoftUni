using System;

namespace CarNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            //•	Ако номерът започва с четна цифра, то той трябва да завършва на нечетна цифра и обратното – ако започва с нечетна, завършва на четна
            //•	Първата цифра от номера е по-голяма от последната
            //•	Сумата от втората и третата цифра трябва да е четно число
            int sumSecThird = 0;
            for (int firstNum = start; firstNum <= end; firstNum++)
            {
                if (firstNum % 2 == 0)
                {
                    for (int seconNum = start; seconNum <= end; seconNum++)
                    {
                        for (int thirdNum = start; thirdNum <= end; thirdNum++)
                        {
                            for (int fourthNum = start; fourthNum <= end; fourthNum++)
                            {
                                sumSecThird = seconNum + thirdNum;
                                if(sumSecThird%2==0 && firstNum>fourthNum && fourthNum%2!=0)
                                {
                                    Console.Write($"{firstNum}{seconNum}{thirdNum}{fourthNum} ");
                                }
                            }
                        }
                    }
                }
                else
                {
                    for (int seconNum = start; seconNum <= end; seconNum++)
                    {
                        for (int thirdNum = start; thirdNum <= end; thirdNum++)
                        {
                            for (int fourthNum = start; fourthNum <= end; fourthNum++)
                            {
                                sumSecThird = seconNum + thirdNum;
                                if (sumSecThird % 2 == 0 && firstNum > fourthNum && fourthNum % 2 == 0)
                                {
                                    Console.Write($"{firstNum}{seconNum}{thirdNum}{fourthNum} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
