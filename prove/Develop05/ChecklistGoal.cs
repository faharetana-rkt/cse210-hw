public class ChecklistGoal : CompletableGoal
{
    private int _bonusAmount;
    private int _timesCompleted;
    private int _timesToComplete;

    public ChecklistGoal (string name, string description, int points, int timesToComplete, int bonusAmount) : base (name, description, points)
    {
        _timesToComplete = timesToComplete;
        _bonusAmount = bonusAmount;
    }
}