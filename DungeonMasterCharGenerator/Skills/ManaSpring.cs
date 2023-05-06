namespace DungeonMasterCharGenerator.Skills;

public class ManaSpring : BaseSkill
{
    public override string      Name             => nameof(ManaSpring);
    public override Ranges      Range            => Ranges.Ranged;
    public override AttackTypes Type             => AttackTypes.Support;
    public override int         Damage           => 0;
    public override int         LevelRequirement => 1;
}