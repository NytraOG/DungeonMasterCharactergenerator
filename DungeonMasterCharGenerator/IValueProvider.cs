using DungeonMasterCharGenerator.Factions;

namespace DungeonMasterCharGenerator;

public interface IValueProvider
{
    void ApplyValues(Monster monster);
}