using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeRoom = Console.ReadLine();
            string evaluation = Console.ReadLine();
            double priceOnePerson = 18.0;
            double priceApart = 25.0;
            double pricePresApart = 35.0;
            double posistiveIndex0 = 1.25;
            double negatifIndex = 0.9;
            double price = 0.0;
            days = days - 1;
            if(days>0 && days<10)
            {
                if(typeRoom=="room for one person"&& evaluation == "positive") 
                { price = (days * priceOnePerson)*posistiveIndex0; }
                else if(typeRoom=="apartment" && evaluation == "positive") 
                { price = (days * priceApart * 0.70) * posistiveIndex0; }
                else if(typeRoom=="president apartment" && evaluation == "positive") 
                { price = (days * pricePresApart * 0.90)*posistiveIndex0; }
                else if (typeRoom == "room for one person" && evaluation == "negative") { price = (days * priceOnePerson) *negatifIndex; }
                else if (typeRoom == "apartment" && evaluation == "negative") 
                { price = (days * priceApart * 0.70)*negatifIndex; }
                else if (typeRoom == "president apartment" && evaluation == "negative") { price = (days * pricePresApart * 0.90)*negatifIndex; }
            }
            else if (days > 10 && days <=15)
            {
                if (typeRoom == "room for one person" && evaluation == "positive")
                { price = (days * priceOnePerson) * posistiveIndex0; }
                else if (typeRoom == "apartment" && evaluation == "positive")
                { price = (days * priceApart * 0.65) * posistiveIndex0; }
                else if (typeRoom == "president apartment" && evaluation == "positive")
                { price = (days * pricePresApart * 0.85) * posistiveIndex0; }
                else if (typeRoom == "room for one person" && evaluation == "negative") { price = (days * priceOnePerson) * negatifIndex; }
                else if (typeRoom == "apartment" && evaluation == "negative")
                { price = (days * priceApart * 0.65) * negatifIndex; }
                else if (typeRoom == "president apartment" && evaluation == "negative") { price = (days * pricePresApart * 0.85) * negatifIndex; }
            }
            else if (days > 15)
            {
                if (typeRoom == "room for one person" && evaluation == "positive")
                { price = (days * priceOnePerson) * posistiveIndex0; }
                else if (typeRoom == "apartment" && evaluation == "positive")
                { price = (days * priceApart * 0.50) * posistiveIndex0; }
                else if (typeRoom == "president apartment" && evaluation == "positive")
                { price = (days * pricePresApart * 0.80) * posistiveIndex0; }
                else if (typeRoom == "room for one person" && evaluation == "negative") { price = (days * priceOnePerson) * negatifIndex; }
                else if (typeRoom == "apartment" && evaluation == "negative")
                { price = (days * priceApart * 0.50) * negatifIndex; }
                else if (typeRoom == "president apartment" && evaluation == "negative") { price = (days * pricePresApart * 0.80) * negatifIndex; }
            }
            Console.WriteLine($"{price:f2}");

        }
    }
}
