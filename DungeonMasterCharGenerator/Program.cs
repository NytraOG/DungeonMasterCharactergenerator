using DungeonMasterCharGenerator;
using DungeonMasterCharGenerator.Factions;
using DungeonMasterCharGenerator.Interfaces;

while (true)
{
    Console.WriteLine("Gieb mir 1 Directory mit deine File oder schreibe -info");

    var input = Console.ReadLine() ?? throw new ArgumentNullException();

    if (input.Trim() == "-info")
        DisplayInfo(input);
    else
    {
        var info = new FileInfo(input);

        if (!info.Exists)
            throw new FileNotFoundException(input);

        File.ReadAllLines(input)
            .ToList()
            .ForEach(l =>
             {
                 if (l.Split(';')[0] == "0")
                     MachEinheit<Monster, Monstermacher>(l);
                 else if (l.Split(';')[0] == "1")
                     MachEinheit<Hero, Heldenmacher>(l);
             });
    }

    Console.ReadKey();
}

void MachEinheit<TUnit, TMacher>(string line)
        where TUnit : BaseUnit
        where TMacher : IMacher<TUnit>
{
    var macher  = Activator.CreateInstance<TMacher>();
    var einheit = macher.MachEinheit(line);

    Console.WriteLine(einheit + Environment.NewLine);
}

void DisplayInfo(string input)
{
    var infoOutput = $"Keywords:{Environment.NewLine}";

    var keywordEnumType = typeof(MonsterKeywords);

    keywordEnumType.GetFields()
                   .ToList()
                   .ForEach(f =>
                    {
                        if (f.Name.Contains("value"))
                            return;

                        infoOutput += f.Name + $"\t| No: {(int)Enum.Parse(typeof(MonsterKeywords), f.Name)}" + Environment.NewLine;
                    });

    Console.WriteLine(infoOutput);
}