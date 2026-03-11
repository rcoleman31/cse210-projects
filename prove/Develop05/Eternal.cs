using System;

public class Eternal : Goal
{
    public Eternal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override string GetDetailsString()
    {
        return $"[∞] {_name} ({_description})";
    }
}