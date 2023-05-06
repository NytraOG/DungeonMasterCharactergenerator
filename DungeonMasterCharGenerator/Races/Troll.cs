using DungeonMasterCharGenerator.Factions;
using DungeonMasterCharGenerator.Skills;

namespace DungeonMasterCharGenerator.Races;

public sealed class Troll : BaseRace
{
    public Troll() => PopulateSkills();

    public override string Name => nameof(Troll);

    public override void ApplyModifier(Hero hero)
    {
        //HP REGEN
        hero.Dexterity    -= 1;
        hero.Constitution += 2;
        hero.Logic        -= 2;
    }

    protected override void PopulateSkills() => Skills.Add(new MeleeAffinity());
}