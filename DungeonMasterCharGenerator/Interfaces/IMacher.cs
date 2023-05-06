using DungeonMasterCharGenerator.Factions;

namespace DungeonMasterCharGenerator.Interfaces;

public interface IMacher<T>
        where T : BaseUnit
{
    public T MachEinheit(string line);
}