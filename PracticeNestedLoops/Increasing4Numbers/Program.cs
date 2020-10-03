using System;

namespace Increasing4Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            bool isFound = false;

            for (int n1 = a; n1 <=b; n1++)
            {
                for (int n2 = n1+1; n2 < b; n2++)
                {
                    for (int n3 = n2+1; n3 < b; n3++)
                    {
                        for (int n4 = n3+1; n4 <=b; n4++)
                        {
                            Console.Write($"{n1} {n2} {n3} {n4} ");
                            Console.WriteLine();
                            isFound = true;
                        }
                       
                    }
                   
                }
            }

            if(!isFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}
