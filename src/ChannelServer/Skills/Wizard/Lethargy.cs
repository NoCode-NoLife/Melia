using Melia.Channel.Network;
using Melia.Channel.Skills.Base;
using Melia.Channel.World.Entities;
using Melia.Shared.Const;
using Melia.Shared.Util;
using Melia.Shared.World;

namespace Melia.Channel.Skills.Wizard
{
	/// <summary>
	/// Handler for the Wizard skill Lethargy.
	/// </summary>
	[SkillHandler(SkillId.Wizard_Lethargy)]
	public class Lethargy : IGroundSkillHandler
	{
		/// <summary>
		/// Handles skill, damaging targets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="castPosition"></param>
		/// <param name="targetPosition"></param>
		public void Handle(Skill skill, Character caster, Position castPosition, Position targetPosition)
		{
			var castRange = castPosition.Get3DDistance(targetPosition);
			if (castRange > skill.Data.MaxRange)
			{
				Log.Warning("Lethargy: Player {0} cast skill farther than max range ({1} > {2}).", caster.Name, castRange, skill.Data.MaxRange);
				return;
			}

			if (skill.SpendSp > 0)
			{
				if (caster.Sp >= skill.SpendSp)
					return;
				caster.ModifySp(-skill.SpendSp);
			}
			skill.IncreaseOverheat();

			var skillHandle = ChannelServer.Instance.World.CreateHandle();
			Send.ZC_SKILL_READY(caster, skill, caster.Position, targetPosition);
			// Sent twice, not too sure why
			Send.ZC_SYNC_START(caster, skillHandle, 1);
			Send.ZC_SYNC_END(caster, skillHandle, 0);
			Send.ZC_SYNC_EXEC_BY_SKILL_TIME(caster, skillHandle, 300);

			var radius = (int)skill.Data.SplashRange * 2;

			var targets = caster.Map.GetAttackableEntitiesInRectangle(caster, castPosition, targetPosition, radius);
			var damage = (int)(caster.GetRandomPAtk() * skill.Data.SkillFactor / 100f);

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, targetPosition, null, damage);

			foreach (var target in targets)
			{
				// TODO add buff when buff code is merged
				// Buff Id: 36, Duration: 20000
				// Buff Id: 452, Duration: 20000
			}
		}
	}
}
