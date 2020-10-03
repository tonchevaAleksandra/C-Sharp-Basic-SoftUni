using System;
using System.Collections.Generic;

namespace GradeBook
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Book book2 = new Book();
            book2.AddGrades(90.1);
            var book = new Book();
            book.AddGrades(89.1);
            //double[] numbers = new [] { 12.7, 10.3, 6.11 };

            //var result = 0.0;
            //foreach (double  number in numbers)
            //{
            //    result += number;
            //}
            //Console.WriteLine(result);

            List<double> grades=new List<double>() { 12.50, 6.8, 8.7 };
            //grades.Add(double.Parse(Console.ReadLine()));


            var result = 0.0;

            foreach (var grade in grades)
            {
                result += grade;
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is: {result:N2}");
            
          

        }
    }
}
