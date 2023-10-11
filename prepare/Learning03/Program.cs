using System;

class Program
{
    static void Main(string[] args)
    {
        /*
		Fraction fract1 = new Fraction();
		Console.WriteLine($"{fract1._top}/{fract1._bottom}");
		Fraction fract2 = new Fraction(5);
		Console.WriteLine($"{fract2._top}/{fract2._bottom}");
		Fraction fract3 = new Fraction(5, 7);
		Console.WriteLine($"{fract3._top}/{fract3._bottom}");
		*/

		//1st constructor with no args
		Fraction fract1 = new Fraction();
		string fractionString = fract1.GetFractionString();
		Console.WriteLine(fractionString);
		double decimalValue = fract1.GetDecimalValue();
		Console.WriteLine(decimalValue);

		//2nd constructor with 1 arg
		Fraction fract2 = new Fraction(5);
		fractionString = fract2.GetFractionString();
		Console.WriteLine(fractionString);
		decimalValue = fract2.GetDecimalValue();
		Console.WriteLine(decimalValue);

		//3rd constructor with 2 args
		Fraction fract3 = new Fraction(3, 4);
		fractionString = fract3.GetFractionString();
		Console.WriteLine(fractionString);
		decimalValue = fract3.GetDecimalValue();
		Console.WriteLine(decimalValue);

		//modified fract1
		fract1.SetBottom(3);
		fractionString = fract1.GetFractionString();
		Console.WriteLine(fractionString);
		decimalValue = fract1.GetDecimalValue();
		Console.WriteLine(decimalValue);
    }
}