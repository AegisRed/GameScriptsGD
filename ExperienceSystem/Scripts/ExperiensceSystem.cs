using Godot;
using System;
using static EventBus;

public partial class ExperienceSystem : Node
{
    [Export] public int MinExpRequirement = 100;
    [Export] public int PerLvlExpRequirement = 50;

    public int CurrentExp { get; private set; } = 0;
    public int CurrentLevel { get; private set; } = 1;

    public override void _Ready()
    {
        base._Ready();
        Subscribe(EventName.ExperienceGained, OnExperienceGained);
    }
    public int GetExpRequirementForLevel(int level)
    {
        return MinExpRequirement + PerLvlExpRequirement * level;
    }
    void OnExperienceGained(Node sender, EventName channel, object[] args)
    {
        CurrentExp += (int)args[0];
        CheckLevelUp();
    }
    void CheckLevelUp()
    {
        while (CurrentExp >= GetExpRequirementForLevel(CurrentLevel))
        {
            CurrentExp -= GetExpRequirementForLevel(CurrentLevel);
            CurrentLevel++;
        }
    }
}
