using System;

namespace mDevMoreOperations
{
	public class MoreOper
	{
		public string One (int input)
		{	int c = input;
			string x = "";
			if (c > 0 && c < 5)
			{	if (c == 1)
					x = "Move left";
				if (c == 2)
					x = "Move right";
				if (c == 3)
					x = "Move up";
				if (c == 4)
					x = "Move down"; 
			} 
			else 
			{	x = "Invalid choice. Turn skipped.";}
			return x;
		}

		public string Two ()
		{	Console.WriteLine("0 = no \n1 = yes \nDoes the computer beep on start up?");
			int y = int.Parse(Console.ReadLine());
			int z;
			string r = "";

			if (y == 1)
			{	Console.WriteLine("0 = no \n1 = yes \nDoes the hard drive spin?");
				z = int.Parse(Console.ReadLine());

				if (z == 1)
					r = "Contact tech support.";
				if (z == 0)
					r = "Check drive contacts.";					
			}

			else if (y == 0)
			{	Console.WriteLine("0 = no \n1 = yes \nDoes the hard drive spin?");
				z = int.Parse(Console.ReadLine());

				if (z == 1)
					r = "Check speaker contacts.";
				if (z == 0)
					r = "Contact the repair center.";
			}
			else {r = "Please input either a 1 or 0 \n0 = no \n1 = yes";}

			return r;
		}

		public int Four ()
		{	int num = 0;
			for (int i =1; i < 1002; i++)
			{	if (i % 11 == 0)
				{num += i;}
			}

			return num;
		}

		public string Five(int inFive)
		{	int g = inFive;
			double result = 0.00;
			for (double o = 0; o < g; o++)
			{ result += (Math.Pow(-1,o))/(2*o + 1);
			}
			result *= 4;
			double error = (Math.Abs(Math.PI - result)/ Math.PI)  * 100;
			return string.Format("Leibniz formula finds pi to be\n{0}\nwhen the number of terms is {1}.\nThe percent error is {2}% when pi is \n{3}.", result, g, error,Math.PI);
		}
	}
}
