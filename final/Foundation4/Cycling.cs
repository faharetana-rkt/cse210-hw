public class Cycling : Activity
{
	private double _speed;
	
	public Cycling(string date, int length, double speed) : base(date, length)
	{
		_speed = speed;
	}
	
	public override double GetSpeed()
	{
		return _speed;
	}
	
	public override double GetPace()
	{
		return 60 / _speed;
	}
	
	public override double GetDistance()
	{
	 	return _speed * (_lengthInMn / 60.0);
	}
	
	public override string GetSummary()
	{
		return $"{_date} {this.GetType().Name} - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
	}
}