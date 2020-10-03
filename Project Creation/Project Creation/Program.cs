using System;

namespace Project_Creation
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = Console.ReadLine();
			int projectsCount = int.Parse(Console.ReadLine());
			int timeProject = int.Parse($"{projectsCount * 3}");
			Console.WriteLine($"The architect {name} will need {timeProject} hours to complete {projectsCount} project/s.");
			

		}
	}
}
