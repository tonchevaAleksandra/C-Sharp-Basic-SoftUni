using System;

namespace TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            if (minutes < 45)
            {
                
                    Console.WriteLine($"{hour}:{minutes + 15}");
            }
            else if (minutes == 45)
            {

                if (hour == 23)
                {
                    Console.WriteLine($"0:00");
                }
                else
                {
                    Console.WriteLine($"{hour + 1}:00");
                }
            }
            else if (minutes > 45 && minutes < 55)
            {
                if (hour == 23)
                {
                    Console.WriteLine($"0:0{minutes - 45}");
                }
                else
                {
                    Console.WriteLine($"{hour+1}:0{minutes - 45}");
                }
            }
            else if (minutes >= 55)
            {
                if (hour == 23)
                {
                    Console.WriteLine($"0:{minutes - 45}");
                }
                else
                {
                    Console.WriteLine($"{hour + 1}:{minutes - 45}");
                }

            }


        }
    }
}
