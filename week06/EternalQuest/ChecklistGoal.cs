public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _timesCompleted = 0;
    }

    public override int RecordEvent()
    {
        if (_timesCompleted < _target)
        {
            _timesCompleted++;
            if (_timesCompleted == _target)
                return Points + _bonus;
            return Points;
        }
        return 0;
    }

    public override bool IsComplete() => _timesCompleted >= _target;

    public override string GetStatus() => $"[{(_timesCompleted >= _target ? "X" : " ")}] Completed {_timesCompleted}/{_target} times";

    public override string GetSaveString() => $"ChecklistGoal|{Name}|{Description}|{Points}|{_target}|{_bonus}|{_timesCompleted}";
}
