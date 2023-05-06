using DungeonMasterCharGenerator.Skills;

namespace DungeonMasterCharGenerator.Factions;

public abstract class BaseUnit
{
    public int             Strength           { get; set; }
    public int             Constitution       { get; set; }
    public int             Dexterity          { get; set; }
    public int             Quickness          { get; set; }
    public int             Intuition          { get; set; }
    public int             Logic              { get; set; }
    public int             Wisdom             { get; set; }
    public int             Willpower          { get; set; }
    public int             Charisma           { get; set; }
    public int             MeleeAttackrating  { get; set; }
    public int             RangedAttackrating { get; set; }
    public int             MagicAttackrating  { get; set; }
    public int             SocialAttackrating { get; set; }
    public int             AmbushAttackrating { get; set; }
    public int             MeleeDefence       { get; set; }
    public int             SocialDefence      { get; set; }
    public int             MagicDefence       { get; set; }
    public int             Mana               { get; set; }
    public int             Health             { get; set; }
    public int             Level              { get; set; }
    public List<BaseSkill> Skills             { get; } = new();

    public abstract void Initialize();

    protected string GetSkilldescriptions()
    {
        var retVal = string.Empty;

        for (var i = 0; i < Skills.Count; i++)
        {
            retVal += $"{Skills[i].Name.ToUpper()}, {Skills[i].Type}, {Skills[i].Range}";

            if (i + 1 != Skills.Count)
                retVal += " | ";
        }

        return retVal;
    }
}