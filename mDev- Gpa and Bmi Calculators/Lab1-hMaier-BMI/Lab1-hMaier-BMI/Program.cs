using System;

namespace Lab1hMaierBMI
{
	class MainClass
	{ 

		public static void Main (string[] args)
		{
			string name;
			int age;
			double weight;
			double height;
			double bmi;

			Console.WriteLine("Please enter your name.");
			name = Console.ReadLine();
			Console.WriteLine("Please enter your age.");
			age = Int32.Parse(Console.ReadLine());
			Console.WriteLine("Please enter your weight in pounds.");
			weight = Int32.Parse(Console.ReadLine());
			Console.WriteLine("Please enter your height in inches.");
			height = Int32.Parse(Console.ReadLine());

			bmi = (weight / (height * height)) * 703;

			Console.WriteLine(name + ", because you're " + age + " years old, " + weight + " pounds, and " + height + " inches,");
			Console.WriteLine("your Body Mass Index (BMI) is " + bmi + ".");
		}
	}
}
