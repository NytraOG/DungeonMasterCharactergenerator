using DungeonMasterCharGenerator.Factions;
using DungeonMasterCharGenerator.Skills;

namespace DungeonMasterCharGenerator.Races;

public sealed class Kobold : BaseRace
{
    public Kobold() => PopulateSkills();

    public override string Name => nameof(Kobold);

    public override void ApplyModifier(Hero hero)
    {
        hero.Wisdom    += 1;
        hero.Quickness += 1;
        hero.Strength  -= 1;
        hero.Willpower -= 1;
    }

    protected override void PopulateSkills() => Skills.Add(new ManaSpring());
}