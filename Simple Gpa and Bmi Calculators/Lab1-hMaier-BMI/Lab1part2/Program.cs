using System;

namespace Lab1part2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double gpa;

			Console.WriteLine("Please input your GPA.");
			gpa = double.Parse(Console.ReadLine());

			if (gpa >= 3.5 && gpa <= 4.0)
			{
				Console.WriteLine("You will graduate with honors!");
			}
			else if (gpa <= 2.0 && gpa > 0.0)
			{
				Console.WriteLine("You're on your way to probation and failing out!");
			}
			else if (gpa > 4.0)
			{
				Console.WriteLine("Yeah, right . . .");
			}
			else if (gpa <= 0.0)
			{
				Console.WriteLine("It's time to reevaluate.");
			}
				
		}
	}
}
