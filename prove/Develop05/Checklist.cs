using System;

public class Checklist : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public Checklist(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _targetCount = target;
        _bonus = bonus;
        _currentCount = 0;
    }

    public override int RecordEvent()
    {
        _currentCount++;

        int total = _points;

        if(_currentCount == _targetCount)
        {
            _isComplete = true;
            total += _bonus;
        }
        return total;
    }

    public override string GetDetailsString()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {_name} ({ _description}) -- Completed {_currentCount}/{_targetCount}";
    }
}