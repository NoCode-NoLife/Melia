using System;
using Melia.Shared.Data.Database;
using Melia.Shared.Tos.Const;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Skills.Handlers.Monsters
{
	[SkillHandler(SkillId.Mon_Onion_Attack1, SkillId.Mon_Onion_red_Skill_1)]
	public class MonOnionAttack1 : SimpleMonsterAttackSkill
	{
		protected override TimeSpan GetDamageDelay(Skill skill)
			=> TimeSpan.FromMilliseconds(1200);

		protected override TimeSpan GetHitDelay(Skill skill)
			=> TimeSpan.FromMilliseconds(1000);

		protected override ISplashArea GetSplashArea(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			var skillParam = skill.GetSplashParameters(caster, caster.Position, target.Position, length: 40, width: 0, angle: 35);
			var splashArea = skill.GetSplashArea(SplashType.Fan, skillParam);

			return splashArea;
		}
	}

	[SkillHandler(SkillId.Mon_Onion_Big_Attack1)]
	public class MonOnionBigAttack1 : SimpleMonsterAttackSkill
	{
		protected override TimeSpan GetDamageDelay(Skill skill)
			=> TimeSpan.FromMilliseconds(800);

		protected override TimeSpan GetHitDelay(Skill skill)
			=> TimeSpan.FromMilliseconds(600);

		protected override ISplashArea GetSplashArea(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			var skillParam = skill.GetSplashParameters(caster, caster.Position, target.Position, length: 60, width: 0, angle: 30);
			var splashArea = skill.GetSplashArea(SplashType.Fan, skillParam);

			return splashArea;
		}
	}
}
