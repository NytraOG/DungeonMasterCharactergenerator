namespace DungeonMasterCharGenerator.Types.SubTypes;

public class Wolf : Animal
{
    public override int          Strength     => 1;
    public override int          Constitution => 1;
    public override int          Dexterity    => 2;
    public override int          Quickness    => 3;
    public override int          Intuition    => 2;
    public override int          Logic        => 1;
    public override int          Wisdom       => 1;
    public override int          Willpower    => 1;
    public override int          Charisma     => 1;
    public override Monstertypes Type         => Monstertypes.Wolf;
}