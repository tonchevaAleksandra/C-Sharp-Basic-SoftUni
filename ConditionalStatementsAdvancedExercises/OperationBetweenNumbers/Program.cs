using System;

namespace OperationBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char operation = Convert.ToChar(Console.ReadLine());
          double numOne =Convert.ToDouble(num1);
            double numTwo = Convert.ToDouble(num2);
            double result = 0.0;
            string evenOrOdd = "";
            if (operation == '+' ) 
            {
                result = numOne + numTwo;
                if (result % 2 == 0) { evenOrOdd = "even"; }
                else { evenOrOdd = "odd"; }
                Console.WriteLine($"{numOne} {operation} {numTwo} = {result} - {evenOrOdd}");
            }
            if (operation == '*')
            {
                result = numOne * numTwo;
                if (result % 2 == 0) { evenOrOdd = "even"; }
                else { evenOrOdd = "odd"; }
                Console.WriteLine($"{numOne} {operation} {numTwo} = {result} - {evenOrOdd}");
            }
            else if ( operation == '-' )
            {
                result = numOne - numTwo;
                if (result % 2 == 0) { evenOrOdd = "even"; }
                else { evenOrOdd = "odd"; }
                Console.WriteLine($"{numOne} {operation} {numTwo} = {result} - {evenOrOdd}");
            }
            else if(operation =='/')
            {
                if (numTwo == 0) 
                { Console.WriteLine($"Cannot divide {numOne} by zero"); }
                else
                {
                    result = numOne / numTwo;
                    Console.WriteLine($"{numOne} {operation} {numTwo} = {result:f2}");
                }
            }
            else if(operation=='%')
            {

                if (numTwo == 0)
                { Console.WriteLine($"Cannot divide {numOne} by zero"); }
                else
                {
                    result = numOne % numTwo;
                    Console.WriteLine($"{numOne} {operation} {numTwo} = {result}");
                }

            }


        }
    }
}
