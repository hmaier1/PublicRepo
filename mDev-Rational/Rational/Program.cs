using System;

namespace Rational
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Rational r1 = new Rational(6, 8);
			Rational r2 = new Rational(1, 3);
			Rational r3, r4, r5, r6, r7;

			Console.WriteLine("First rational: " + r1);
			Console.WriteLine("Second rational: " + r2);

			if (r1.Equals(r2))
				Console.WriteLine("r1 and r2 equal");
			else 
				Console.WriteLine("r1 and r2 not equal");
			
			r3 = r1.Reciprical();
			Console.WriteLine("reciprical of r1 is: " + r3);

			r4 = r1.Add(r2);
			r5 = r1.Subtract(r2);
			r6 = r1.Multiply(r2);
			r7 = r1.Divide(r2);

			Console.WriteLine("+ 13/12:  " + r4);
			Console.WriteLine("- 5/12:  " + r5);
			Console.WriteLine("* 1/4:  " + r6);
			Console.WriteLine("/ 9/4:  " + r7);

		}
	}
}
