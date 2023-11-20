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
}