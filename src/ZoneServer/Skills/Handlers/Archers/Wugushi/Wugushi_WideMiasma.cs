using System;
using System.Threading.Tasks;
using Melia.Shared.L10N;
using Melia.Shared.Game.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Buffs;
using static Melia.Shared.Util.TaskHelper;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Archers.Wugushi
{
	/// <summary>
	/// Handler for the Wugushi skill Wide Miasma.
	/// </summary>
	[SkillHandler(SkillId.Wugushi_WideMiasma)]
	public class Wugushi_WideMiasma : IGroundSkillHandler
	{
		/// <summary>
		/// Handles the skill, insert debuffs to enemies inside of the effect area
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		/// <param name="designatedTarget"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity designatedTarget)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);
			caster.StartBuff(BuffId.WideMiasma_Buff, skill.Level, 0, TimeSpan.FromSeconds(15), caster);

			Send.ZC_SKILL_READY(caster, skill, caster.Position, caster.Position);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, caster.Position, caster.Direction, farPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, caster.Position, null);

			// TODO: Cut in half in PVP Zones
			var radius = 120;
			var splashArea = new Circle(caster.Position, radius);

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
			await Task.Delay(TimeSpan.FromSeconds(1));

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			foreach (var target in targets.LimitRandom(10))
			{
				target.StartBuff(BuffId.WideMiasma_Debuff, skill.Level, (int)skill.Id, TimeSpan.FromSeconds(15), caster);
				target.StartBuff(BuffId.DecreaseHeal_Debuff, skill.Level, this.GetHealingReduction(skill), TimeSpan.FromSeconds(20), caster);
			}
		}

		/// <summary>
		/// Used by the buff once the target takes damage.
		/// </summary>
		/// <param name="buff"></param>
		/// <param name="skill></param>
		public static void BuffDealsDamage(Buff buff, Skill skill)
		{
			var damageMultiplier = 1f;

			if (buff.Caster.TryGetBuff(BuffId.Zhendu_Buff, out var ZhenduBuff))
				damageMultiplier = ZhenduBuff.NumArg1;

			var skillHitResult = SCR_SkillHit(buff.Caster, buff.Target, skill);
			skillHitResult.Damage *= damageMultiplier;

			// The damage amount is unknow, for now we are dealing
			// the same amount as the original skill does
			buff.Target.TakeDamage(skillHitResult.Damage, buff.Caster);

			var hit = new HitInfo(buff.Caster, buff.Target, skill.Id, skillHitResult.Damage, HitResultType.Buff26);

			Send.ZC_HIT_INFO(buff.Caster, buff.Target, hit);
		}

		/// <summary>
		/// Return the Healing Reduction value
		/// </summary>
		/// <param name="skill"></param>
		/// <returns></returns>
		private float GetHealingReduction(Skill skill)
		{
			return (3 + 3 * skill.Level) * 1000;
		}
	}
}
