using System;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Swordsman
{
	/// <summary>
	/// Handler for the Swordman skill Pain Barrier.
	/// </summary>
	[SkillHandler(SkillId.Swordman_PainBarrier)]
	public class Swordman_PainBarrier : ISelfSkillHandler
	{
		/// <summary>
		/// Handles skill, applying the buffs to the caster.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="dir"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Direction dir)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			caster.StartBuff(BuffId.PainBarrier_Buff, skill.Level, 0, GetBuffTime(skill), caster);
			caster.StartBuff(BuffId.PainBarrierImmune_Buff, skill.Level, 0, TimeSpan.FromSeconds(3), caster);

			Send.ZC_SKILL_MELEE_TARGET(caster, skill, caster, null);
		}

		/// <summary>
		/// Returns the duration of the main buff applied by this skill.
		/// </summary>
		/// <param name="skill"></param>
		/// <returns></returns>
		public static TimeSpan GetBuffTime(Skill skill)
		{
			// Guru lists this skill with 5 levels that slowly increased
			// the duration from 10s to 30s. But on the current version
			// its max level is set to 1 and the skill factors work out to
			// the same 30s duration from the get-go. We'll still
			// calculate it though, just in case factors or levels
			// change.

			var baseValue = skill.Properties.GetFloat(PropertyName.SklFactor, 0);
			var perLevel = skill.Properties.GetFloat(PropertyName.SklFactorByLevel, 0);

			var value = baseValue + skill.Level * perLevel;

			// TODO: Enable once we have PvP.
			//if (skill.Owner.InPvp)
			//	value /= 2;

			return TimeSpan.FromMilliseconds(value);
		}
	}
}
