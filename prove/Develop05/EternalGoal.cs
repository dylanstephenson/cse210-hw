public class EternalGoal : Goal{

    // No attributes outside of super class, so it goes right to constructor
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }
    // Methods
    public override int RecordEvent()
    {
        return _points;
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}";
    }
}