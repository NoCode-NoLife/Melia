using System;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Skills.Handlers.Archers.QuarrelShooter
{
	/// <summary>
	/// Handler for the Quarrel Shooter skill Kneeling Shot.
	/// </summary>
	[SkillHandler(SkillId.QuarrelShooter_Kneelingshot)]
	public class QuarrelShooter_Kneelingshot : ISelfSkillHandler
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
			if (caster.IsBuffActive(BuffId.Archer_Kneelingshot))
			{
				caster.StopBuff(BuffId.Archer_Kneelingshot);
			}
			else
			{
				if (!caster.TrySpendSp(skill))
				{
					caster.ServerMessage(Localization.Get("Not enough SP."));
					return;
				}

				var criticalBonus = 0;

				// Focusing gives 2% crit bonus per level
				if (caster.TryGetActiveAbilityLevel(AbilityId.Focusing, out var level))
					criticalBonus = 2 * level;

				caster.StartBuff(BuffId.Archer_Kneelingshot, skill.Level, criticalBonus, TimeSpan.Zero, caster);
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			Send.ZC_SKILL_MELEE_TARGET(caster, skill, caster, null);
		}
	}
}
