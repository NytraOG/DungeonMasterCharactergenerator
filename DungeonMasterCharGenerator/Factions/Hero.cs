using DungeonMasterCharGenerator.Classes;
using DungeonMasterCharGenerator.Races;

namespace DungeonMasterCharGenerator.Factions;

public class Hero : BaseUnit
{
    public BaseRace      Race       { get; set; }
    public BaseHeroclass Heroclass  { get; set; }
    public int           Experience { get; set; }

    public override void Initialize()
    {
        Strength     = 100;
        Constitution = 100;
        Dexterity    = 100;
        Quickness    = 100;
        Intuition    = 100;
        Logic        = 100;
        Wisdom       = 100;
        Willpower    = 100;
        Charisma     = 100;

        Race.ApplyModifier(this);
        Heroclass.ApplyModifier(this);

        Skills.AddRange(Race.Skills);

        Health = 3 * Constitution + 2 * Strength;
    }

    public override string ToString() => $"{Race.Name}, {Heroclass.Name} Level {Level} with {Experience} xp, Stats: str {Strength}, con {Constitution}, dex {Dexterity}, hp {Health}{Environment.NewLine}" +
                                         $"Skills: {GetSkilldescriptions()}";
}