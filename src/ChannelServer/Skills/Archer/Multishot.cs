using Melia.Channel.Network;
using Melia.Channel.Skills.Base;
using Melia.Channel.World.Entities;
using Melia.Shared.Const;
using Melia.Shared.World;

namespace Melia.Channel.Skills.Archer
{
	/// <summary>
	/// Handler for the Swordsman skill Thrust.
	/// </summary>
	[SkillHandler(SkillId.Archer_Multishot)]
	public class Multishot : IGroundSkillHandler
	{
		public void Handle(Skill skill, Character caster, Position castPosition, Position targetPosition)
		{
			skill.IncreaseOverheat();

			// TODO: Cancel if not enough SP?
			if (skill.SpendSp > 0)
				caster.ModifySp(-skill.SpendSp);

			var targets = caster.Map.GetAttackableEntitiesInRange(caster, targetPosition, (int)skill.Data.SplashRange);
			var damage = caster.GetRandomPAtk();

			Send.ZC_NORMAL_Skill_4E(caster, skill.Id, 1);
			Send.ZC_NORMAL_Skill(caster, skill, targetPosition, caster.Direction, true);
			Send.ZC_NORMAL_Unknown_06(caster, targetPosition);
			Send.ZC_SYNC_START(caster, 1234, 1);
			Send.ZC_SYNC_END(caster, 1234, 0);
			Send.ZC_SYNC_EXEC_BY_SKILL_TIME(caster, 1234, skill.Data.HitDelay);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, targetPosition, null, 0);
			Send.ZC_SYNC_EXEC(caster, 1234);

			for (var i = 0; i < 10; i++)
			{
				Send.ZC_NORMAL_Unknown_06(caster, targetPosition);
				Send.ZC_SYNC_START(caster, 1234, 1);
				Send.ZC_SYNC_END(caster, 1234, 0);
				Send.ZC_SYNC_EXEC_BY_SKILL_TIME(caster, 1234, skill.Data.HitDelay);
				Send.ZC_SYNC_EXEC(caster, 1234);

				foreach (var target in targets)
				{
					if (target.TakeDamage(damage, caster, DamageVisibilityModifier.Hit, i + 1))
						Send.ZC_SKILL_CAST_CANCEL(caster, target);
				}
			}

			Send.ZC_SKILL_DISABLE(caster);
		}
	}
}
