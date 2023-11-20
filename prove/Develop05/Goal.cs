public abstract class Goal
{
	protected string _description;
	protected int _points;
	protected string _name;

	public Goal(string name, string description, int points)
	{
		_name = name;
		_description = description;
		_points = points;
	}

	public virtual int RecordEvent()
	{
		return _points;
	}

	public abstract string ToStr();

	public abstract string ToSavedStr();

}