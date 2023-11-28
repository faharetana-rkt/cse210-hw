public class Running: Activity
{
	private double _distance;
	
	public Running(string date, int length, double distance) : base(date, length)
	{
		_distance = distance;
	}
	
	public override double GetSpeed()
	{
		return (_distance / _lengthInMn) * 60; 
	}
	
	public override double GetPace()
	{
		return _lengthInMn / _distance;
	}
	
	public override string GetSummary()
	{
		return $"{_date} {this.GetType().Name} - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
	}
	
	public override double GetDistance()
	{
		return _distance;
	}	
}
