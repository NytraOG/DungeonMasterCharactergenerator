using DungeonMasterCharGenerator.Factions;

namespace DungeonMasterCharGenerator.Classes;

public abstract class BaseHeroclass
{
    public abstract string Name { get; }

    public abstract void ApplyModifier(Hero hero);
}