using Melia.Channel.Network;
using Melia.Channel.Skills.Base;
using Melia.Channel.World.Entities;
using Melia.Shared.Const;
using Melia.Shared.Util;
using Melia.Shared.World;

namespace Melia.Channel.Skills.Wizard
{
	/// <summary>
	/// Handler for the Wizard skill Magic Missile.
	/// </summary>
	[SkillHandler(SkillId.Wizard_MagicMissile)]
	public class MagicMissile : IGroundSkillHandler
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
			// This is just a test for a dedicated skill handler, the code
			// was largely copied from the default handler for now, without
			// referencing logs. And the packets are definitely not right
			// yet.

			var castRange = castPosition.Get3DDistance(targetPosition);
			if (castRange > skill.Data.MaxRange)
			{
				Log.Warning("Magic Missile: Player {0} cast skill farther than max range ({1} > {2}).", caster.Name, castRange, skill.Data.MaxRange);
				return;
			}

			if (skill.SpendSp > 0)
			{
				if (caster.Sp >= skill.SpendSp)
					return;
				caster.ModifySp(-skill.SpendSp);
			}

			skill.IncreaseOverheat();

			Send.ZC_SKILL_READY(caster, skill, caster.Position, targetPosition);
			// Find targets sorted by distance within spell range
			var targets = caster.Map.GetAttackableEntitiesInRangeSortedByDistance(caster, targetPosition, skill.Data.MaxRange);
			// Do damage calculation if targets exist
			if (targets != null && targets.Count > 0)
			{
				var damage = (int)(caster.GetRandomPAtk() * skill.Data.SkillFactor / 100f);

				var skillHandle = ChannelServer.Instance.World.CreateHandle();
				for (var i = 0; i < targets.Count - 1; i++)
				{
					Send.ZC_SYNC_START(caster, skillHandle, 1);
					Send.ZC_NORMAL_SkillEffectSplash(caster, targets[i], targets[i + 1]);
					Send.ZC_SYNC_END(caster, skillHandle, 0);
				}

				Send.ZC_SKILL_MELEE_GROUND(caster, skill, targetPosition, targets[0], 1, damage);
				targets[0].TakeDamage(damage, caster, DamageVisibilityModifier.Invisible, 0);
				//targets[0].TakeDamage(damage, caster, DamageVisibilityModifier.Invisible, 1);
				//targets[0].TakeDamage(damage, caster, DamageVisibilityModifier.Invisible, 2);

				foreach (var target in targets)
				{
					if (target != targets[0])
						if (target.TakeDamage(damage, caster, DamageVisibilityModifier.Skill, 0))
							Send.ZC_SKILL_CAST_CANCEL(caster, target);
				}
			}
			else
			{
				Send.ZC_SKILL_MELEE_GROUND(caster, skill, targetPosition, null, 0);
			}
		}
	}
}
