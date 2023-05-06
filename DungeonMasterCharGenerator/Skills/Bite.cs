namespace DungeonMasterCharGenerator.Skills;

public class Bite : BaseSkill
{
    public override string      Name             => nameof(Bite);
    public override Ranges      Range            => Ranges.Melee;
    public override AttackTypes Type             => AttackTypes.Piercing;
    public override int         Damage           => 6;
    public override int         LevelRequirement => 1;
}