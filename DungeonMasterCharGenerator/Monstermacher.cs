using DungeonMasterCharGenerator.Factions;
using DungeonMasterCharGenerator.Interfaces;
using DungeonMasterCharGenerator.Keywords;
using DungeonMasterCharGenerator.Types;
using DungeonMasterCharGenerator.Types.SubTypes;

namespace DungeonMasterCharGenerator;

public class Monstermacher : IMacher<Monster>
{
    public Monster MachEinheit(string line)
    {
        var elemente = line.Split(';');

        var monstertype    = CreateMonstertype((Monstertypes)int.Parse(elemente[1]));
        var monsterKeyword = CreateKeyword((MonsterKeywords)int.Parse(elemente[2]));
        var monsterLevel   = int.Parse(elemente[3]);

        var monster = new Monster
        {
            Level       = monsterLevel,
            Monstertype = monstertype,
            Keyword     = monsterKeyword
        };

        monster.Initialize();

        return monster;
    }

    private BaseMonstertype CreateMonstertype(Monstertypes monstertype) => monstertype switch
    {
        Monstertypes.Wolf => new Wolf(),
        _ => throw new ArgumentOutOfRangeException(nameof(monstertype), monstertype, null)
    };

    private BaseKeyword CreateKeyword(MonsterKeywords monsterKeyword) => monsterKeyword switch
    {
        MonsterKeywords.Pup => new Pup(),
        MonsterKeywords.Hunter => new Hunter(),
        MonsterKeywords.Alpha => new Alpha(),
        _ => throw new ArgumentOutOfRangeException(nameof(monsterKeyword), monsterKeyword, null)
    };

}