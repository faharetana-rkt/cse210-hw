public class ChecklistGoal : CompletableGoal
{
    private int _bonusAmount;
    private int _timesCompleted = 0;
    private int _timesToComplete;

    public ChecklistGoal(string name, string description, int points, int timesToComplete, int bonusAmount) : base(name, description, points)
    {
        _timesToComplete = timesToComplete;
        _bonusAmount = bonusAmount;
    }

    public override string ToStr()
    {
        string str = $"[{Marker()}] {_name} ({_description}) -- Currently Completed: {_timesCompleted}/{_timesToComplete}";
        return str;
    }

    public override string ToSavedStr()
    {
        string className = nameof(ChecklistGoal);
        string savedStr = $"{className}:{_name},{_description},{_points},{_bonusAmount},{_timesToComplete},{_timesCompleted}";
        return savedStr;
    }

    private int CompleteCheckList()
    {
        return _timesCompleted++;
    }

    public void SetTimesCompleted(int times)
    {
        _timesCompleted = times;
    }

    public override int RecordEvent()
    {
        CompleteCheckList();
        if (_timesToComplete == _timesCompleted)
        {
            CompleteGoal();
            int points = _bonusAmount + _points;
            return points;
        }
        else
        {
            return _points;
        }
    }
}