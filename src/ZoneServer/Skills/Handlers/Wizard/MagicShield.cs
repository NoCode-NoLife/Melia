using System;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;

namespace Melia.Zone.Skills.Handlers.Wizard
{
	/// <summary>
	/// Handler for the Wizard skill Magic Shield.
	/// </summary>
	[SkillHandler(SkillId.Wizard_ReflectShield)]
	public class MagicShield : ISelfSkillHandler
	{
		/// <summary>
		/// Handles skill, applying a buff to the caster.
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

			var target = caster;

			var duration = TimeSpan.FromMinutes(30);
			target.StartBuff(BuffId.ReflectShield_Buff, skill.Level, 0, duration, caster);

			Send.ZC_SKILL_MELEE_TARGET(caster, skill, target, null);

			// Packet logs show an empty hit being sent here, but it doesn't
			// appear to be necessary.
			//var hit = new SkillHitInfo(caster, target, skill, 0, TimeSpan.FromMilliseconds(50), TimeSpan.Zero);
			//hit.HitInfo.ResultType = HitResultType.None;
			//Send.ZC_SKILL_HIT_INFO(caster, hit);
		}
	}
}
