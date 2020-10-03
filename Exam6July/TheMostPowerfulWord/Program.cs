using System;

namespace TheMostPowerfulWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            double winSum = int.MinValue;
            string winWord = "";

            while (word != "End of words")
            {
                char firstLetter = '0';
                double currentSum = 0;
                char[] array = word.ToCharArray();
                for (int i = 0; i < word.Length; i++)
                {
                    char letter = array[i];
                    currentSum += letter;
                    if(i==0)
                    {
                         firstLetter = letter;
                    }
                   
                }
               if(firstLetter=='a' || firstLetter=='A' || firstLetter=='e' ||firstLetter=='E' || firstLetter=='i' ||firstLetter=='I' ||firstLetter=='o' ||firstLetter=='O' || firstLetter=='u' ||firstLetter=='U' || firstLetter=='y' ||firstLetter=='Y')
                {
                    currentSum *= word.Length;
                }
               else
                {
                    currentSum = Math.Floor(currentSum / word.Length);
                }
               if(currentSum>winSum)
                {
                    winSum = currentSum;
                    winWord = word;
                }
                word = Console.ReadLine();
            }
           
            Console.WriteLine($"The most powerful word is {winWord} - {winSum}");
        }
    }
}
