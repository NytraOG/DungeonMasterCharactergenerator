using DungeonMasterCharGenerator.Skills;

namespace DungeonMasterCharGenerator.Keywords;

public sealed class Alpha : BaseKeyword
{
    public Alpha() => PopulateSkills();

    protected override double          StrengthModifier     => 2;
    protected override double          ConstitutionModifier => 5;
    protected override double          DexterityModifier    => 1.5;
    protected override double          QuicknessModifier    => 1;
    protected override double          IntuitionModifier    => 1.5;
    protected override double          LogicModifier        => 3;
    protected override double          WisdomModifier       => 3;
    protected override double          WillpowerModifier    => 4;
    protected override double          CharismaModifier     => 4;
    public override    MonsterKeywords Keyword              => MonsterKeywords.Alpha;

    protected override void PopulateSkills()
    {
        Skills.Add(new Bite());
        Skills.Add(new Shred());
        Skills.Add(new GatherThePack());
    }
}