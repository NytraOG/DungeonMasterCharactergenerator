using DungeonMasterCharGenerator.Factions;
using DungeonMasterCharGenerator.Skills;

namespace DungeonMasterCharGenerator.Races;

public abstract class BaseRace
{
    public abstract string          Name   { get; }
    public          List<BaseSkill> Skills { get; } = new();

    public abstract void ApplyModifier(Hero hero);

    protected abstract void PopulateSkills();
}