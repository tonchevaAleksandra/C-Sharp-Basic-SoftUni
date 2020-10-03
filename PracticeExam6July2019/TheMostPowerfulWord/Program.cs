using System;

namespace TheMostPowerfulWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int maxPoints = int.MinValue;
            string winWord = "";
            while (command != "End of words")
            {
                bool isVowel = false;
                string word = command;
                double points = 0;
                char[] array = word.ToCharArray();

                for (int i = 0; i < word.Length; i++)
                {
                    char letter = array[i];
                    points += letter;
                    char firstLetter = array[0];
                    firstLetter = char.ToLower(firstLetter);
                    if (firstLetter == 'a' || firstLetter == 'e' || firstLetter == 'i' || firstLetter == 'o' ||
                        firstLetter == 'u' || firstLetter == 'y' )
                    {
                        isVowel = true;
                    }
                }
                if (isVowel)
                {
                    points *= word.Length;
                }
                else
                {
                    points = Math.Floor(points / word.Length);
                }
                if (points > maxPoints)
                {
                    winWord = word;
                    maxPoints = Convert.ToInt32(points);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"The most powerful word is {winWord} - {maxPoints}");
        }
    }
}
