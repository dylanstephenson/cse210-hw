using System.ComponentModel;

public class SimpleGoal : Goal{

    // attributes
    private bool _isComplete;

    // Constructor
    public SimpleGoal(string name, string description, int points, bool isComplete = false) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    // Methods
    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }
    public override bool IsComplete()
    {
        if (_isComplete)
        {
            return true;
        }
        else {
            return false;
        }
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}