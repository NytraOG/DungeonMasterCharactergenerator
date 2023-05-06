using DungeonMasterCharGenerator.Skills;

namespace DungeonMasterCharGenerator.Keywords;

public sealed class Hunter : BaseKeyword
{
    public Hunter() => PopulateSkills();

    protected override double          StrengthModifier     => 2;
    protected override double          ConstitutionModifier => 2;
    protected override double          DexterityModifier    => 1.5;
    protected override double          QuicknessModifier    => 1;
    protected override double          IntuitionModifier    => 1;
    protected override double          LogicModifier        => 1;
    protected override double          WisdomModifier       => 2;
    protected override double          WillpowerModifier    => 2;
    protected override double          CharismaModifier     => 1;
    public override    MonsterKeywords Keyword              => MonsterKeywords.Hunter;

    protected override void PopulateSkills()
    {
        Skills.Add(new Bite());
        Skills.Add(new Shred());
    }
}