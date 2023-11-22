public class EternalGoal : Goal
{
	public EternalGoal(string name, string description, int points) : base(name, description, points)
	{
	}

	public override string ToStr()
	{
		string str = $"[ ] {_name} ({_description})";
		return str;
	}

	public override string ToSavedStr()
	{
		string className = nameof(EternalGoal);
		string saved = $"{className}:{_name},{_description},{_points}";
		return saved;
	}
}
