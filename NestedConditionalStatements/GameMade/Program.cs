using System;

namespace eziTuraConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравей сега ще играеш конзолно ези или тура!");
            Console.WriteLine("Моля мини на английски (латиница) ако сега не си!");
            Console.WriteLine("И изписвай думите точно както е посочено, за да може компютъра да те разбира правилно!");
            Console.Write("Пъвро въведи твоето име:");
            string playerName = Console.ReadLine();
            Console.WriteLine("Напиши'start', за да започнеш игра! (Ако играеш за първи път прочети първо правилата!)");
            Console.WriteLine("За да прочетеш правилата напиши 'rules'");
            string firstChoice = Console.ReadLine();
        rules:
            if (firstChoice != "start")
            {

                Console.WriteLine("Ето ги и правилата!");
                Console.WriteLine("Компютъра създава случайно число между 0 и 1000.");
                Console.WriteLine("Ако числото е четно той хвърля 'ези' !");
                Console.WriteLine("Ако числото е нечетно - 'тура' !");
                Console.WriteLine("Когато познаеш какво е хвърлил компютъра печелиш точка, ако не познаеш той печели точка.");
                Console.WriteLine("Който първи направи 5 точки печели играта!");
                Console.WriteLine("Сега нека се изправим срещу компютъра! напиши 'start', за да започнеш игра!");
                firstChoice = Console.ReadLine();

            }

            if (firstChoice == "start")
            {
                Console.WriteLine("Направи своя избор ezi/tura !");
                Console.WriteLine("Напиши 'ezi' или 'tura' ");
            restart:
                int pcPoints = 0;
                int playerPoints = 0;
            again:
                int pcChoice = 0;//tura
                Random random = new Random();
                int trows = random.Next(1, 1000);
                if (trows % 2 == 0)
                {
                    pcChoice = 1;// ez
                }


                string playerChoice = Console.ReadLine();
                if (playerChoice == "ezi")
                {
                    if (pcChoice == 1)//ez        player point
                    {
                        Console.WriteLine($"Случайното число е {trows}");
                        Console.WriteLine("Твоя избор : ezi ");
                        Console.WriteLine("Компютъра  : ezi ");
                        Console.WriteLine("Tочка за теб!");

                        playerPoints = playerPoints + 1;
                    }
                    if (pcChoice == 0)//tura       pc point
                    {
                        Console.WriteLine($"Случайното число е {trows}");
                        Console.WriteLine("Твоя избор : ezi ");
                        Console.WriteLine("Компютъра  : tura ");
                        Console.WriteLine("Tочка за компютъра!");
                        pcPoints = pcPoints + 1;
                    }
                }
                if (playerChoice == "tura")
                {
                    if (pcChoice == 0) //tura       player point
                    {
                        Console.WriteLine($"Случайното число е {trows}");
                        Console.WriteLine("Твоя избор : tura ");
                        Console.WriteLine("Компютъра  : tura ");
                        Console.WriteLine("Tочка за теб!");
                        playerPoints = playerPoints + 1;
                    }
                    if (pcChoice == 1) //ez        pc point
                    {
                        Console.WriteLine($"Случайното число е {trows}");
                        Console.WriteLine("Твоя избор : tura ");
                        Console.WriteLine("Компютъра  : ezi ");
                        Console.WriteLine("Tочка за компютъра!");
                        pcPoints = pcPoints + 1;

                    }
                }
                Console.WriteLine($"Точките на {playerName} :{playerPoints}");
                Console.WriteLine($"точките на компютъра :{pcPoints}");
                Console.WriteLine("Избери отново! Напиши 'ezi' или 'tura' ");
                string playAgain;
                if (playerPoints > 4)
                {
                    Console.WriteLine("Поздравления! :) ");
                    Console.WriteLine($"Ти спечели с {playerPoints} на {pcPoints} за теб.");
                    Console.WriteLine("Ако искаш да играеш пак напиши 'yes' !");
                    Console.WriteLine("Ако не искаш да играеш пак напиши 'no' !");
                    playAgain = Console.ReadLine();
                    if (playAgain == "yes")
                    {
                        Console.WriteLine("Напиши 'ezi' или 'tura' ");
                        goto restart;
                    }
                    if (playAgain == "no")
                    {
                        Console.WriteLine("Благодаря, че избра да играеш 'Конзолно ези или тура' ");
                        goto end;
                    }

                    goto end;
                }
                if (pcPoints > 4)
                {
                    Console.WriteLine("За малко! ");
                    Console.WriteLine($"Ти загуби {playerPoints} на {pcPoints} за компютъра.");
                    Console.WriteLine("Ако искаш да играеш пак напиши 'yes' !");
                    Console.WriteLine("Ако не искаш да играеш пак напиши 'no' !");
                    playAgain = Console.ReadLine();
                    if (playAgain == "yes")
                    {
                        Console.WriteLine("Напиши 'ezi' или 'tura' ");
                        goto restart;
                    }
                    if (playAgain == "no")
                    {
                        Console.WriteLine("Благодаря, че избра да играеш 'Конзолно ези или тура' ");
                        goto end;
                    }

                }
                goto again;
            end: Console.ReadLine();
            }
            else
            {
                goto rules;
            }

        }
    }
}
