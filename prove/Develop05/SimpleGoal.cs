public class SimpleGoal : CompletableGoal
{
    public SimpleGoal(string name, string description, int points) : base (name, description, points)
    {

    }

    public override int RecordEvent()
    {
        CompleteGoal();
        return _points;
    }

    public override string ToSavedStr()
    {
        string className = nameof(SimpleGoal);
		string saved = $"{className}:{_name},{_description},{_points},{_isFinished}";
		return saved;
    }
}