public abstract class Goal
{
    // attributes
    protected string _shortName;
    protected string _description;
    protected int _points;
    
    // Constructor
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // methods
    public abstract int RecordEvent();
    
    public abstract bool IsComplete();

      public string GetName() 
    {
        return _shortName;
    }
    public virtual string GetDetailsString()
    {
        return $"({_description})";
    }

    public abstract string GetStringRepresentation();
}