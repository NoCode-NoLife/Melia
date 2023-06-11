using System.Linq;
using Melia.Shared.Data.Database;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Skills.Handlers.Monsters
{
	/// <summary>
	/// Handles default monster skills that target the ground around
	/// a target.
	/// </summary>
	[SkillHandler(SkillUseType.TARGET_GROUND, "^Mon_")]
	public class TargetGroundAttack1 : ITargetSkillHandler
	{
		// It's currently not clear whether we'll be able to handle all
		// Attack1 monster skills in one handler or whether we'll need
		// dedicated handlers, but chances are that most of them will
		// essentially be the same, so we'll start with one handler.

		/// <summary>
		/// Uses skill on target.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		public void Handle(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			var hitTime = skill.Data.HitTime.First();
			var hitDelay = skill.Data.HitDelay;
			var damageDelay = hitTime + hitDelay;

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, target.Position, null);

			// TODO: Wait for "hitTime" ms before sending hit info. It seems
			//   like some skills run on a timer, such as Onion_Attack1.
			//   This skill gets initiated, but the hit info is only sent
			//   after a delay. Given that you can move out of harms way
			//   with that particular skill, I assume the target finding
			//   happens after the delay, when the poison cloud animation
			//   appears.

			var hit = new SkillHitInfo(caster, target, skill, 42, damageDelay, hitDelay);
			target.TakeDamage(hit.HitInfo.Damage, caster);

			Send.ZC_SKILL_HIT_INFO(caster, hit);
		}
	}
}
