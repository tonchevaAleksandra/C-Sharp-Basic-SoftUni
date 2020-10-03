using System;

namespace StreamOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            bool cExist = false;
            bool oExist = false;
            bool nExist = false;
            string word = "";
            while (input!="End")
            {
                input = Console.ReadLine();
                char lett = char.Parse(input);
                if((lett >= 'a' && lett <= 'z') || (lett >= 'A' && lett <= 'Z'))
                {
                    if(lett=='c' && !cExist)
                    {
                        cExist = true;
                    }
                    else if(lett=='o' && !oExist)
                    {
                        oExist = true;
                    }
                    else if(lett=='n' && !nExist)
                    {
                        nExist = true;
                    }
                    else
                    {
                        word +=lett;
                       
                    }
                    if(cExist && oExist && nExist)
                    {

                    }
                    input = Console.ReadLine();
                }
            }

        }
    }
}
