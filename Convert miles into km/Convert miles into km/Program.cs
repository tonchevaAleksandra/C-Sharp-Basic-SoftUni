using System;

namespace Convert_miles_into_km
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("How many miles you want to convert into km?");
			double miles = double.Parse(Console.ReadLine());
			double km = miles * 1.61;
			Console.WriteLine(miles + " miles are " + km + " km");
		}
	}
}
