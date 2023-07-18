using System;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;

namespace Melia.Zone.Skills.Handlers.Archer
{
	/// <summary>
	/// Handler for the Archer skill Leap.
	/// </summary>
	[SkillHandler(SkillId.Archer_Jump)]
	public class Leap : IGroundSkillHandler
	{
		/// <summary>
		/// Handles skill, moving the character back.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		/// <param name="target"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(false);

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);

			var duration = TimeSpan.FromSeconds(1);
			caster.StartBuff(BuffId.Skill_NoDamage_Buff, 0, 0, duration, caster);

			var distance = this.GetJumpDistance(caster, skill);
			var targetPos = caster.Position.GetRelative(caster.Direction.Backwards, distance);
			targetPos = caster.Map.Ground.GetLastValidPosition(caster.Position, targetPos);

			caster.Position = targetPos;

			Send.ZC_NORMAL.LeapJump(caster, targetPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);
		}

		/// <summary>
		/// Returns the distance to jump back.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		/// <returns></returns>
		private float GetJumpDistance(ICombatEntity caster, Skill skill)
		{
			// This value seemingly changed over time, as Guru lists the
			// skill with a max level of 5 and a distance ranging from
			// 90 to 130.

			return 183.8f;
		}
	}
}
