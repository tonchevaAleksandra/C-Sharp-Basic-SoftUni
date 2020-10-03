using System;

namespace WeddingSeats
{
    class Program
    {
        static void Main(string[] args)
        {
            //            •	Последния сектор от секторите -символ(B - Z)
            //•	Броят на редовете в първия сектор -цяло число(1 - 100)
            //•	Броят на местата на нечетен ред -цяло число(1 - 24)
            //Да се отпечата на конзолата всяко място на отделен ред по следния формат:
            //{ сектор}
            //{ ред}
            //{ място}
            //Накрая трябва да отпечата броя на всички места

            char end = char.Parse(Console.ReadLine());
            int rowsSector1 = int.Parse(Console.ReadLine());
            int seatsOddRow = int.Parse(Console.ReadLine());
            int counterSeats = 0;

            for (char sector = 'A'; sector <= end; sector++)
            {
                if (sector == 'A')
                {
                    for (int row = 1; row <= rowsSector1; row++)
                    {
                        if (row % 2 != 0)
                        {
                            for (char seats = 'a'; seats < 'a' + seatsOddRow; seats++)
                            {
                                counterSeats++;
                                Console.WriteLine($"{sector}{row}{seats} ");
                            }
                        }
                        else
                        {
                            for (char seats = 'a'; seats < 'a' + seatsOddRow +2; seats++)
                            {
                                counterSeats++;
                                Console.WriteLine($"{sector}{row}{seats} ");
                            }
                        }

                    }
                }
                
            }
            for (char sector = 'B'; sector <= end; sector++)
            
            {
                for (int row = 1; row <= rowsSector1 + 1; row++)
                {
                    if (row % 2 != 0)
                    {
                        for (char seats = 'a'; seats < 'a' + seatsOddRow; seats++)
                        {
                            counterSeats++;
                            Console.WriteLine($"{sector}{row}{seats} ");
                        }
                    }
                    else
                    {
                        for (char seats = 'a'; seats < 'a' + seatsOddRow + 2; seats++)
                        {
                            counterSeats++;
                            Console.WriteLine($"{sector}{row}{seats} ");
                        }
                    }

                }
                rowsSector1++;
            }
            Console.WriteLine(counterSeats);
        }
    }
}
