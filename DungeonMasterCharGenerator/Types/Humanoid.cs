namespace DungeonMasterCharGenerator.Types;

public abstract class Humanoid : BaseMonstertype
{
    public override int          Strength     => 2;
    public override int          Constitution => 2;
    public override int          Dexterity    => 2;
    public override int          Quickness    => 2;
    public override int          Intuition    => 3;
    public override int          Logic        => 3;
    public override int          Wisdom       => 2;
    public override int          Willpower    => 1;
    public override int          Charisma     => 2;
    public override Monstertypes Type         => Monstertypes.Humanoid;
}