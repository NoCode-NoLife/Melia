using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using static Melia.Shared.Util.TaskHelper;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Matador
{
	/// <summary>
	/// Handler for the Matador skill Paso Doble
	/// </summary>
	[SkillHandler(SkillId.Matador_PasoDoble)]
	public class Matador_PasoDoble : IGroundSkillHandler
	{
		/// <summary>
		/// Handles skill, damages and knodown enemies nearby
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
			caster.SetAttackState(true);

			caster.StartBuff(BuffId.Faena_Buff);

			Send.ZC_SKILL_READY(caster, skill, caster.Position, caster.Position);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, caster.Position, caster.Direction, Position.Zero);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

			var splashArea = new Circle(caster.Position, 65);

			CallSafe(this.Attack(skill, caster, splashArea));
		}

		/// <summary>
		/// Executes the actual attack after a delay.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private async Task Attack(Skill skill, ICombatEntity caster, ISplashArea splashArea)
		{
			var delay = TimeSpan.FromMilliseconds(100);

			await Task.Delay(delay);

			var damageDelay = TimeSpan.FromMilliseconds(300);
			var skillHitDelay = TimeSpan.Zero;

			var skillHits = new List<SkillHitInfo>();
			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var modifier = SkillModifier.MultiHit(2);

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);

				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHitInfo = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);

				skillHits.Add(skillHitInfo);

				var debuffVal = 4f * skill.Level;

				target.StartBuff(BuffId.DecreaseHeal_Debuff, skill.Level, debuffVal, TimeSpan.FromSeconds(3), caster);

				// Paso Doble: Remove Knockdown
				if (!caster.IsAbilityActive(AbilityId.Matador12))
				{
					var knockBackInfo = new KnockBackInfo(caster.Position, target.Position, HitType.KnockBack, 300, 89);
					target.Position = knockBackInfo.ToPosition;

					Send.ZC_KNOCKDOWN_INFO(caster, target, knockBackInfo);
				}
			}

			Send.ZC_SKILL_HIT_INFO(caster, skillHits);
		}
	}
}
