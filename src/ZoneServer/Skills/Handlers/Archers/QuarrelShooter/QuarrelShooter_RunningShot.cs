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
	/// Handler for the Quarrel Shooter skill Running Shot
	/// </summary>
	[SkillHandler(SkillId.QuarrelShooter_RunningShot)]
	public class QuarrelShooter_RunningShot : ISelfSkillHandler
	{
		/// <summary>
		/// Handles skill, applying the buff to the caster.
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
			target.StartBuff(BuffId.RunningShot_Buff, skill.Level, skill.Properties.GetFloat(PropertyName.SkillFactor), duration, caster);

			Send.ZC_SKILL_MELEE_TARGET(caster, skill, target, null);
		}
	}
}
