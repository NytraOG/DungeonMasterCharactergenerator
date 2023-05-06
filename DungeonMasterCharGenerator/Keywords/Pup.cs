using DungeonMasterCharGenerator.Skills;

namespace DungeonMasterCharGenerator.Keywords;

public sealed class Pup : BaseKeyword
{
    public Pup() => PopulateSkills();

    protected override double          StrengthModifier     => 1;
    protected override double          ConstitutionModifier => 1;
    protected override double          DexterityModifier    => 1;
    protected override double          QuicknessModifier    => 1;
    protected override double          IntuitionModifier    => 1;
    protected override double          LogicModifier        => 1;
    protected override double          WisdomModifier       => 1;
    protected override double          WillpowerModifier    => 1;
    protected override double          CharismaModifier     => 1;
    public override    MonsterKeywords Keyword              => MonsterKeywords.Pup;

    protected override void PopulateSkills() => Skills.Add(new Bite());
}