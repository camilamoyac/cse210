public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        DisplayPlayerInfo();

        
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }
    public void ListGoalNames ()
    {}
    public void ListGoalDetails ()
    {}
    public void CreateGoal ()
    {}
    public void RecordEvent ()
    {}
    public void SaveGoals ()
    {}
    public void LoadGoals ()
    {}
    
}