using System;

namespace Savings
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double monthIncome = double.Parse(Console.ReadLine());
            int cntMonths = int.Parse(Console.ReadLine());
            double personalExpenses = double.Parse(Console.ReadLine());
            double unexpected = 0.3 * monthIncome;
            double savedPerMonth = monthIncome - personalExpenses - unexpected;
            double maxSaved = cntMonths * savedPerMonth;
            double maxPersent = savedPerMonth / monthIncome * 100.00;
            Console.WriteLine($"She can save {maxPersent:f2}%");
            Console.WriteLine($"{maxSaved:f2}");
        }
    }
}
