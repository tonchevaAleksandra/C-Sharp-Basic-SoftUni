using System;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double numL = (double.Parse(Console.ReadLine()) * 100)/120;
            double numW = ((double.Parse(Console.ReadLine()) - 1) * 100)/70;
            
            double people = (Math.Floor(numL) * Math.Floor(numW)) - 3;
            Console.WriteLine(Math.Floor(people));
           
        }
    }
}
