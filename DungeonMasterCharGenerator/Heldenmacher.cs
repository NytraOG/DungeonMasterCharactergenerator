using DungeonMasterCharGenerator.Classes;
using DungeonMasterCharGenerator.Factions;
using DungeonMasterCharGenerator.Interfaces;
using DungeonMasterCharGenerator.Races;

namespace DungeonMasterCharGenerator;

public class Heldenmacher : IMacher<Hero>
{
    public Hero MachEinheit(string line)
    {
        var elemente = line.Split(';');

        var race      = CreateRace(elemente[1]);
        var heroclass = CreateHeroclass(elemente[2]);
        var heroXp    = int.Parse(elemente[3]);

        var hero = new Hero
        {
            Experience = heroXp,
            Race       = race,
            Heroclass  = heroclass
        };

        hero.Initialize();

        return hero;
    }

    private BaseHeroclass CreateHeroclass(string className) => className switch
    {
        nameof(Energist) => new Energist(),
        _ => throw new ArgumentOutOfRangeException(nameof(className), className, null)
    };

    private BaseRace CreateRace(string raceName) => raceName switch
    {
        nameof(Orc) => new Orc(),
        nameof(Troll) => new Troll(),
        nameof(Kobold) => new Kobold(),
        _ => throw new ArgumentOutOfRangeException(nameof(raceName), raceName, null)
    };
}