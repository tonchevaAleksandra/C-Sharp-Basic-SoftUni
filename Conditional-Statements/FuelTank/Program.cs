using System;

namespace FuelTank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double litersFuel = double.Parse(Console.ReadLine());
           


                if (fuel == "Diesel" || fuel == "Gasoline" || fuel == "Gas")
            {
                char[] array = fuel.ToCharArray();
                for (int i = 0; i < array.Length; i++)
                {
                    char let = array[i];
                    if (char.IsUpper(let))
                        array[i] = char.ToLower(let);
                }
                string result = new string(array);
                if (litersFuel >= 25)
                {

                    Console.WriteLine($"You have enough {result}.");
                }
                else if (litersFuel < 25)
                {
                    Console.WriteLine($"Fill your tank with {result}!");
                }
            }
            else if(fuel != "Diesel" || fuel != "Gasoline" || fuel != "Gas")
            {
                Console.WriteLine($"Invalid fuel!");
            }

        }
         
}
}
