using System;

namespace CharacterSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pesho
            //length= 4
            // 0 1 2 3 4
            string text = Console.ReadLine();
            
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);
            }
        }
    }
}
