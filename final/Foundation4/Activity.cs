public abstract class Activity
{
	protected string _date;
	protected int _lengthInMn;
	
	public Activity(string date, int length)
	{
		_date = date;
		_lengthInMn = length;
	}
	
	public virtual string GetSummary()
	{
		return $"{_date} {this.GetType().Name}";
	}
	
	public abstract double GetDistance();
	
	public abstract double GetSpeed();
	
	public abstract double GetPace();
}
