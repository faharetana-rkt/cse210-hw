public class CompletableGoal : Goal
{
    protected bool _isFinished = false;

    protected CompletableGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override string ToStr()
    {
        string str = $"[{Marker()}] {_name} ({_description})";
        return str;
    }

    public override string ToSavedStr()
    {
        string className = nameof(CompletableGoal);
        string saved = $"{className}:{_name},{_description},{_points},{_isFinished}";
        return saved;
    }

    protected string Marker()
    {
        if (_isFinished)
        {
            return "X";
        }
        else
        {
            return " ";
        }
    }

    protected bool CompleteGoal()
    {
        return _isFinished = true;
    }

    public void SetIsFinished(bool finished)
    {
        _isFinished = finished;
    }
}