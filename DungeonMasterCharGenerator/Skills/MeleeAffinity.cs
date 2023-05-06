namespace DungeonMasterCharGenerator.Skills;

public class MeleeAffinity : BaseSkill
{
    public override string      Name             => nameof(MeleeAffinity);
    public override Ranges      Range            => Ranges.None;
    public override AttackTypes Type             => AttackTypes.Support;
    public override int         Damage           => 0;
    public override int         LevelRequirement => 1;
}