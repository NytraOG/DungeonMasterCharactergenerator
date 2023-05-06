using DungeonMasterCharGenerator.Factions;

namespace DungeonMasterCharGenerator.Classes;

public class Energist : BaseHeroclass
{
    public override string Name => nameof(Energist);

    public override void ApplyModifier(Hero hero)
    {
        hero.AmbushAttackrating = (int)(hero.AmbushAttackrating * 1.05);
        hero.MagicAttackrating  = (int)(hero.MagicAttackrating * 1.05);
        hero.MeleeAttackrating  = (int)(hero.MeleeAttackrating * 1.05);
        hero.RangedAttackrating = (int)(hero.RangedAttackrating * 1.05);
        hero.SocialAttackrating = (int)(hero.SocialAttackrating * 1.05);

        hero.MeleeDefence  = (int)(hero.MeleeDefence * 1.1);
        hero.SocialDefence = (int)(hero.SocialDefence * 0.85);
        hero.Health        = (int)(hero.Health * 1.2);
        hero.Mana          = (int)(hero.Mana * 0.9);
    }
}