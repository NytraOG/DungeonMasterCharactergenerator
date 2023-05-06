using DungeonMasterCharGenerator.Factions;
using DungeonMasterCharGenerator.Skills;

namespace DungeonMasterCharGenerator.Keywords;

public abstract class BaseKeyword : IValueProvider
{
    protected abstract double          StrengthModifier     { get; }
    protected abstract double          ConstitutionModifier { get; }
    protected abstract double          DexterityModifier    { get; }
    protected abstract double          QuicknessModifier    { get; }
    protected abstract double          IntuitionModifier    { get; }
    protected abstract double          LogicModifier        { get; }
    protected abstract double          WisdomModifier       { get; }
    protected abstract double          WillpowerModifier    { get; }
    protected abstract double          CharismaModifier     { get; }
    public abstract    MonsterKeywords Keyword              { get; }
    public             List<BaseSkill> Skills               { get; } = new();

    public void ApplyValues(Monster monster)
    {
        monster.Strength     = (int)(monster.Strength * StrengthModifier);
        monster.Constitution = (int)(monster.Constitution * ConstitutionModifier);
        monster.Dexterity    = (int)(monster.Dexterity * DexterityModifier);
        monster.Quickness    = (int)(monster.Quickness * QuicknessModifier);
        monster.Intuition    = (int)(monster.Intuition * IntuitionModifier);
        monster.Logic        = (int)(monster.Logic * LogicModifier);
        monster.Wisdom       = (int)(monster.Wisdom * WisdomModifier);
        monster.Willpower    = (int)(monster.Willpower * WillpowerModifier);
        monster.Charisma     = (int)(monster.Charisma * CharismaModifier);
    }

    protected abstract void PopulateSkills();
}