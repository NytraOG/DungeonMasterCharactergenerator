namespace DungeonMasterCharGenerator.Skills;

public abstract class BaseSkill
{
    public abstract string      Name             { get; }
    public abstract Ranges      Range            { get; }
    public abstract AttackTypes Type             { get; }
    public abstract int         Damage           { get; }
    public abstract int         LevelRequirement { get; }
}