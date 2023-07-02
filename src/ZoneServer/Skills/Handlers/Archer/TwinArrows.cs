using System;
using System.Threading.Tasks;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Archer
{
	/// <summary>
	/// Handles the Archer skill TwinArrows.
	/// </summary>
	[SkillHandler(SkillId.Archer_TwinArrows)]
	public class TwinArrows : ITargetSkillHandler
	{
		/// <summary>
		/// Handles the skill, do two consecutive hits on the enemy.
		/// </summary>
		public void Handle(Skill skill, ICombatEntity caster, ICombatEntity designatedTarget)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.TurnTowards(designatedTarget);

			if (designatedTarget == null)
			{
				return;
			}

			if (!caster.Position.InRange2D(designatedTarget.Position, skill.Data.MaxRange))
			{
				caster.ServerMessage(Localization.Get("Too far away."));
				return;
			}

			this.Attack(skill, caster, designatedTarget);
		}

		/// <summary>
		/// Executes the actual attack.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="designatedTarget"></param>
		private async void Attack(Skill skill, ICombatEntity caster, ICombatEntity designatedTarget)
		{
			var damageDelay = TimeSpan.Zero;
			var skillHitDelay = skill.Data.DefaultHitDelay;

			// TODO: Add more 50% damage to enemies using cloth armor type

			var skillHitResult = SCR_SkillHit(caster, designatedTarget, skill);
			designatedTarget.TakeDamage(skillHitResult.Damage, caster);

			var skillHit = new SkillHitInfo(caster, designatedTarget, skill, skillHitResult, damageDelay, skillHitDelay);

			Send.ZC_SKILL_READY(caster, skill, caster.Position, caster.Position);
			Send.ZC_SKILL_FORCE_TARGET(caster, designatedTarget, skill, skillHit);
			Send.ZC_SKILL_HIT_INFO(caster, skillHit);

			await Task.Delay(TimeSpan.FromMilliseconds(200));

			var skillHitResult2 = SCR_SkillHit(caster, designatedTarget, skill);
			designatedTarget.TakeDamage(skillHitResult2.Damage, caster);

			var skillHit2 = new SkillHitInfo(caster, designatedTarget, skill, skillHitResult2, damageDelay, skillHitDelay);

			Send.ZC_SKILL_HIT_INFO(caster, skillHit2);
		}
	}
}
