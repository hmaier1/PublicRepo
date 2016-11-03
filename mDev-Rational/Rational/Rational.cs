using System;

namespace Rational
{
	public class Rational
	{
		private int numerator;
		private int denominator;

		public Rational (int numer, int denom){
			numerator = numer;
			denominator = denom;
			Reduce();
		}
	
		public Rational Reciprocal (){
			return new Rational (denominator, numerator);
		}

		public override string ToString() {
			return numerator + "/" + denominator;
		}

		public Rational Add (Rational op2) {
			int d1 = this.denominator;
			int d2 = op2.denominator;
			int denom = d1 * d2;
			int numer = (d2 * this.numerator) + (d1 * op2.numerator);
			return new Rational(numer, denom);
		}

		public Rational Subtract (Rational op2) {
			int d1 = this.denominator;
			int d2 = op2.denominator;
			int denom = d1 * d2;
			int numer = (d2 * this.numerator) - (d1 * op2.numerator);
			return new Rational(numer, denom);
		}

		public Rational Multiply (Rational op2) {
			int denom = this.denominator * op2.denominator;
			int numer = this.numerator * op2.numerator;
			return new Rational(numer, denom);
		}

		public Rational Divide (Rational op2) {
			Rational localOp2 = op2.Reciprocal();//works 3/1
			return this.Multiply(localOp2);
		}

		public bool Equals (Rational op2) {
			if (this.numerator.Equals(op2.numerator)){
				if (this.denominator.Equals(op2.denominator))
					return true;
				else 
					return false;}
			else 
				return false;
		}

		private void Reduce (){
			if (numerator != 0) {
				int common = GCD(Math.Abs(numerator),denominator);
				numerator = numerator / common;
				denominator = denominator / common;
				}
			}

		private int GCD(int num1, int num2){
			while( num1 != num2 )
				if (num1 > num2)
					num1 = num1 - num2;
				else 
					num2 = num2 - num1;
			return num1;
    	}


	}
}

