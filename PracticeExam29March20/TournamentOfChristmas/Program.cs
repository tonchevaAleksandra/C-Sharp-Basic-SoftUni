using System;

namespace TournamentOfChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Първоначално от конзолата се прочита броя дни на турнира – цяло число в интервала[1… 20]
            //До получаване на командата "Finish" се чете:
            // Спорт – текст
            //За всеки спорт се прочита:
            //o Резултат – текст с възможности: "win" или "lose"

            int days = int.Parse(Console.ReadLine());
            
            int countWin = 0;
            int countLose = 0;

            double earnedMoney = 0.0;
            int countDays = 0;

            while (countDays<days)
            {
                string sport = Console.ReadLine();
                int countWinPerDay = 0;
                int countLosePerDay = 0;
                double earnedMoneyPerDay = 0.0;
                while (sport!="Finish")
                {
                    
                    string result = Console.ReadLine();
                    switch (result)
                    {
                        case "win":
                            countWinPerDay++; earnedMoneyPerDay += 20;
                            break;
                        case "lose":
                            countLosePerDay++;
                            break;
                    }
                    sport = Console.ReadLine();

                }
                if (countWinPerDay > countLosePerDay)
                {
                    earnedMoneyPerDay *= 1.1; countWin++;
                    
                }
                else
                {
                    countLose++;
                }

                    countDays++;
                earnedMoney += earnedMoneyPerDay;

            }
            if(countWin>countLose)
            {
                earnedMoney *= 1.2;
                Console.WriteLine($"You won the tournament! Total raised money: {earnedMoney:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {earnedMoney:f2}");
            }

        }
    }
}
