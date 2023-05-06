using DungeonMasterCharGenerator.Keywords;
using DungeonMasterCharGenerator.Types;

namespace DungeonMasterCharGenerator.Factions;

public class Monster : BaseUnit
{
    public BaseMonstertype Monstertype { get; set; }
    public BaseKeyword     Keyword     { get; set; }

    public override void Initialize()
    {
        Monstertype.ApplyValues(this);
        Keyword.ApplyValues(this);

        ApplyLevelBonus();
        PopulateSkills();

        Health = 3 * Constitution + 2 * Strength;
    }

    private void PopulateSkills() => Skills.AddRange(Keyword.Skills);

    private void ApplyLevelBonus()
    {
        if (Level == 1)
            return;

        var levelModifier = 1.4 * Level;

        Strength     += (int)(Monstertype.Strength * levelModifier);
        Constitution += (int)(Monstertype.Constitution * levelModifier);
        Dexterity    += (int)(Monstertype.Dexterity * levelModifier);
        Quickness    += (int)(Monstertype.Quickness * levelModifier);
        Intuition    += (int)(Monstertype.Intuition * levelModifier);
        Logic        += (int)(Monstertype.Logic * levelModifier);
        Wisdom       += (int)(Monstertype.Wisdom * levelModifier);
        Willpower    += (int)(Monstertype.Willpower * levelModifier);
        Charisma     += (int)(Monstertype.Charisma * levelModifier);
    }

    public override string ToString() => $"{Monstertype.Type}, {Keyword.Keyword} Level {Level}, Stats: str {Strength}, con {Constitution}, dex {Dexterity}, hp {Health}{Environment.NewLine}" +
                                         $"Skills: {GetSkilldescriptions()}";
}