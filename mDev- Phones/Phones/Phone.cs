using System;

namespace Phones
{
	class Phone
	{
		private string model;
		private string manuf;
		private double price;
		private string owner;
		private string screenColor;
		private float screenWidth;
		private float screenLength;

		public string Model
		{get{return model;} set{model = value;}} 
		public string Manuf
		{get{return manuf;} set{manuf = value;}} 
		public double Price
		{get{return price;} set{price = value;}} 
		public string Owner
		{get{return owner;} set{owner = value;}} 
		public string ScreenColor
		{get{return screenColor;} set{screenColor = value;}} 
		public float ScreenWidth
		{get{return screenWidth;} set{screenWidth = value;}} 
		public float ScreenLength
		{get{return screenLength;} set{screenLength = value;}} 

		public Phone ()
		{
			model = "null";
			manuf = "null";
			price = 0.00;
			owner = "null";
			screenColor = "null";
			screenLength = 0.0f;
			screenWidth = 0.0f;
		}
		public Phone (string model, string manuf, double price, string owner, string screenColor, float screenLength, float screenWidth)
		{
			this.model = model;
			this.manuf = manuf;
			this.price = price;
			this.owner = owner;
			this.screenColor = screenColor;
			this.screenLength = screenLength;
			this.screenWidth = screenWidth;
		}

		public override string ToString ()
		{
			return string.Format ("[Phone: Model={0}, Manuf={1}, Price={2}, Owner={3}, ScreenColor={4}, ScreenWidth={5}, ScreenLength={6}]", Model, Manuf, Price, Owner, ScreenColor, ScreenWidth, ScreenLength);
		}
	}

}

