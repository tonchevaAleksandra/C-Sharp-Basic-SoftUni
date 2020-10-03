using System;

namespace Double_inches
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("How many inches you want to convert into sentimeters?");
			double inches = double.Parse(Console.ReadLine());
			double sentimeter = inches * 2.54;
			Console.WriteLine( inches + " inches are " + sentimeter + " sentimeters.");
		}
	}
}
