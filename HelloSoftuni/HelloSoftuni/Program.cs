using System;

namespace HelloSoftUni


{
	class Program
	{
		static void Main(string[] args)

		{

			Console.WriteLine("Hello! What's your name?");
			string name = Console.ReadLine();
			Console.WriteLine("Hello, " + name + ", what's your family name?");
			string familyName = Console.ReadLine();
			Console.WriteLine("What's your age, " + name + " " +  familyName + " ?");
			int age = int.Parse(Console.ReadLine());
			Console.WriteLine("In 5 years you'll be: " + (age + 5));
			
	
		
			

}
	}
}
