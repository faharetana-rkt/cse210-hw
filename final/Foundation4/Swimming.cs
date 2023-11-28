public class Swimming: Activity
{
	private int _laps;
	
	public Swimming(string date, int length, int laps) : base(date, length)
	{
		_laps = laps;
	}
	
	public override double GetDistance()
	{
		return _laps * 50 / 1000.0;
	}
	
	public override double GetSpeed()
	{
		double distance = GetDistance();
		return (distance / _lengthInMn) * 60; 
	}
	
	public override double GetPace()
	{
		double distance = GetDistance();
		return _lengthInMn / distance;
	}
	
	public override string GetSummary()
	{
		return $"{_date} {this.GetType().Name} - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
	}
}
