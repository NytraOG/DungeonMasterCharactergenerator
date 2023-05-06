using DungeonMasterCharGenerator.Factions;

namespace DungeonMasterCharGenerator.Types;

public abstract class BaseMonstertype : IValueProvider
{
    public abstract int          Strength          { get; }
    public abstract int          Constitution      { get; }
    public abstract int          Dexterity         { get; }
    public abstract int          Quickness         { get; }
    public abstract int          Intuition         { get; }
    public abstract int          Logic             { get; }
    public abstract int          Wisdom            { get; }
    public abstract int          Willpower         { get; }
    public abstract int          Charisma          { get; }
    public          float        BaseMeleeDefense  => 2 * Dexterity + Quickness;
    public          float        BaseRangedDefense => 2 * Quickness + Dexterity;
    public          float        BaseMagicDefense  => 2 * Willpower + Wisdom;
    public          float        BaseSocialDefense => 2 * Logic + Charisma;
    public          int          BaseInitiative    => 2 * Intuition + Quickness;
    public          int          Health            { get; set; }
    public          double       MaximumHealth     { get; set; }
    public abstract Monstertypes Type              { get; }

    public void ApplyValues(Monster monster)
    {
        monster.Strength     = Strength;
        monster.Constitution = Constitution;
        monster.Dexterity    = Dexterity;
        monster.Quickness    = Quickness;
        monster.Intuition    = Intuition;
        monster.Logic        = Logic;
        monster.Wisdom       = Wisdom;
        monster.Willpower    = Willpower;
        monster.Charisma     = Charisma;
    }
}