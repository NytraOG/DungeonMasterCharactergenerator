namespace DungeonMasterCharGenerator.Skills;

public class Shred : BaseSkill
{
    public override string      Name             => nameof(Shred);
    public override Ranges      Range            => Ranges.Melee;
    public override AttackTypes Type             => AttackTypes.Piercing;
    public override int         Damage           => 4;
    public override int         LevelRequirement => 1;
}