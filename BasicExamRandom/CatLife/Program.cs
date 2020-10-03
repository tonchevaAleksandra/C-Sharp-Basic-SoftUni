using System;

namespace CatLife
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeCat = Console.ReadLine();
            char gender = char.Parse(Console.ReadLine());
            double catManoths = 0;
            //14 * 12 = 168 
            //=> 168 / 6 = 28 
            switch (typeCat)
            {
                case "British Shorthair":
                    switch (gender)
                    {
                        case 'm':
                            catManoths = Math.Floor((13 * 12)*1.00 / 6);
                            break;
                        case 'f':
                            catManoths = Math.Floor((14 * 12) * 1.00 / 6);
                            break;
                      
                    }
                    break;
                case "Siamese":
                    switch (gender)
                    {
                        case 'm':
                            catManoths = Math.Floor((15 * 12) * 1.00 / 6);
                            break;
                        case 'f':
                            catManoths = Math.Floor((16 * 12) * 1.00 / 6);
                            break;
                      
                    }

                    break;
                case "Persian":
                    switch (gender)
                    {
                        case 'm':
                            catManoths = Math.Floor((14 * 12) * 1.00 / 6);
                            break;
                        case 'f':
                            catManoths = Math.Floor((15 * 12) * 1.00 / 6);
                            break;
                       
                    }
                    break;
                case "Ragdoll":
                    switch (gender)
                    {
                        case 'm':
                            catManoths = Math.Floor((16 * 12) * 1.00 / 6);
                            break;
                        case 'f':
                            catManoths = Math.Floor((17 * 12) * 1.00 / 6);
                            break;
                      
                    }
                    break;
                case "American Shorthair":
                    switch (gender)
                    {
                        case 'm':
                            catManoths = Math.Floor((12 * 12) * 1.00 / 6);
                            break;
                        case 'f':
                            catManoths = Math.Floor((13 * 12) * 1.00 / 6);
                            break;
                       
                    }
                    break;
                case "Siberian":
                    switch (gender)
                    {
                        case 'm':
                            catManoths = Math.Floor((11 * 12) * 1.00 / 6);
                            break;
                        case 'f':
                            catManoths = Math.Floor((12 * 12) * 1.00 / 6);
                            break;
                       
                    }
                    break;
                default:
                    Console.WriteLine($"{typeCat} is invalid cat!");
                    return;


            }
            Console.WriteLine($"{catManoths} cat months");

        }
    }
}
