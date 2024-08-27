using Godot;
using System;
using static EventBus;
using static ExperienceSystem;
namespace Systems;

public partial class ExperienceGiver : Node
{
    [Export] public int ExpAmount = 50;
    public delegate void ExpirienceGainedHandler(int expAmount);
    public void GiveExperience()
    {
        Publish(this, EventName.ExperienceGained, ExpAmount);
    }
}
