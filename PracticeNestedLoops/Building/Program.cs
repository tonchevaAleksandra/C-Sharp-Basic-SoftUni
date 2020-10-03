using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int roomsPerFloor = int.Parse(Console.ReadLine());

            for (int i = floors; i >=1; i--)
            {
                for (int j = 0; j < roomsPerFloor; j++)
                {
                    if(floors==1 || i==floors)
                    {
                        Console.Write($"L{i}{j} ");
                    }
                    if(i%2==0 && i!=floors)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    else if(i%2!=0 && i != floors)
                    {
                        Console.Write($"A{i}{j} ");
                    }


                }
                Console.WriteLine();
            }

        }
    }
}
