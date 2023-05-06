using DungeonMasterCharGenerator.Factions;
using DungeonMasterCharGenerator.Skills;

namespace DungeonMasterCharGenerator.Races;

public sealed class Orc : BaseRace
{
    public Orc() => PopulateSkills();

    public override string Name => nameof(Orc);

    public override void ApplyModifier(Hero hero)
    {
        hero.Strength  += 2;
        hero.Logic     -= 2;
        hero.Willpower += 1;
        hero.Wisdom    -= 1;
    }

    protected override void PopulateSkills() => Skills.Add(new Roar());
}