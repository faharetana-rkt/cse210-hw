public class Fraction
{
	private int _top = 1;
	private int _bottom = 1;

	//Constructor with zero argument
	public Fraction()
	{
	}

	//Constructor with one argument of _top
	public Fraction(int wholeNumber)
	{
		_top = wholeNumber;
	}

	//Constructor with two arguments for _top and _bottom
	public Fraction (int top, int bottom)
	{
		_top = top;
		_bottom = bottom;
	}

	//Getter and Setters for _top
	public int GetTop () {
		return _top;
	}

	public void SetTop (int numerator) {
		_top = numerator;
	}

	//Getter and Setter for _bottom
	public int GetBottom () {
		return _bottom;
	}

	public void SetBottom (int denominator) {
		_bottom = denominator;
	}

	public string GetFractionString () {
		return $"{_top}/{_bottom}";
	}

	public double GetDecimalValue () {
		double division = (double) _top / (double)_bottom;
		return division;
	}

}