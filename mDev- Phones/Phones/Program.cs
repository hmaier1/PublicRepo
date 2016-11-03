using System;

namespace Phones
//Include a ToString method for each of your classes.
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Phone p1 = new Phone();
			Phone p2 = new Phone();

			Battery b1 = new Battery();
			Battery b2 = new Battery();

			p1.ScreenColor = "blue";
			p1.ScreenLength = 6.0f;
			p1.Owner = "Phil";

			p2.Owner = "Lil";

			string a = p1.ToString();
			string b = p2.ToString();
			string c = b1.ToString();
			string d = b1.ToString();

			Console.WriteLine(a);
			Console.WriteLine(b);
			Console.WriteLine(c);
			Console.WriteLine(d);
		}
	}
}
