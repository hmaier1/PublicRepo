using System;

namespace mDevMoreOperations
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		/*	Product p1 = new Product();
			Product p2 = new Product("PeanutButter","Hormel",2.99f,16.1f);
			Console.WriteLine(p1);
			Console.WriteLine(p2);
			p1.Name = "Grape Jelly";
			p2.Name = "Orange Marmelade";
			p1.Price += .13f;
			p2.Price += 1.25f;
			p2.Manufacturer = "PeaterPan";
			p1.Manufacturer = "Skippy";
			Console.WriteLine("\n" + p1);
			Console.WriteLine(p2); 
		*/
		 
		 	MoreOper more = new MoreOper();
		//	Console.WriteLine(more.One(3));
		Console.WriteLine(more.Two());
		//	Console.WriteLine(more.Four());
			Console.WriteLine(more.Five(999));

		}
	}
}