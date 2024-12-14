public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _targetAmount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetAmount, int bonusPoints) : base(name, description, points)
    {
        _targetAmount = targetAmount;
        _bonusPoints = bonusPoints;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {
        return true;
    }
    public override string GetStringRepresentation()
    {
        return "";
    }
    public override string GetDetailString()
    {
        return "";
    }

}