using System;

namespace mDevMoreOperations
{
	public class Product
	{	private string name, manu;
		private float price, size;	

		public string Name 
		{ 	get {return name;}
			set {name = value;}}
		public string Manufacturer 
		{ 	get {return manu;}
			set {manu = value;}}
		public float Price 
		{ 	get {return price;}
			set {price = value;}}
		public float Size 
		{ 	get {return size;}
			set {size = value;}}

		public Product()
		{	name = "xyz";
			manu = "abc";
			price = 100.00f;
			size = 1.0f;
		}
		public Product (string name, string manu, float price, float size)
		{	this.name = name;
			this.manu = manu;
			this.price = price;
			this.size = size;
		}

		public override string ToString ()
		{
			return string.Format ("[Product: Name={0}, Manu={1}, Price={2}, Size={3}]", Name, Manufacturer, Price, Size);
		}
	}
}

