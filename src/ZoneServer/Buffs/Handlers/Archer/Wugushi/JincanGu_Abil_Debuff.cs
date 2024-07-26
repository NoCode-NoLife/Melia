using System;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Buffs.Handlers.Archer.Wugushi
{
	/// <summary>
	/// Handle for the JincanGu Debuff (GoldenFrog), which ticks damage every second.
	/// </summary>
	[BuffHandler(BuffId.JincanGu_Abil_Debuff)]
	public class JincanGu_Abil_Debuff : BuffHandler
	{
		private const string AdditionalHits = "Wugushi.JincanGu_Abil_Debuff";

		public override async void OnStart(Buff buff)
		{
			buff.Vars.SetInt(AdditionalHits, 5);
		}

		public override async void WhileActive(Buff buff)
		{
			if (buff.Target.IsDead)
				return;

			this.DamagesTarget(buff);

			// We are Damaging 5x additional hits
			if (buff.Vars.GetInt(AdditionalHits) <= 5 && buff.Vars.GetInt(AdditionalHits) >= 1)
			{
				var damageThickDelay = 1000f;
				var skillLevel = (int)buff.NumArg1;

				Crescendo_Bane_Buff.TryApply(buff.Caster, ref damageThickDelay);

				await Task.Delay(TimeSpan.FromMilliseconds(damageThickDelay));

				var remaningAdditionalHits = buff.Vars.GetInt(AdditionalHits);
				buff.Vars.SetInt(AdditionalHits, remaningAdditionalHits - 2);

				this.DamagesTarget(buff);

				await Task.Delay(TimeSpan.FromMilliseconds(damageThickDelay));
			} else
			{
				var damageThickDelay = 2000f;
				var skillLevel = (int)buff.NumArg1;

				Crescendo_Bane_Buff.TryApply(buff.Caster, ref damageThickDelay);

				await Task.Delay(TimeSpan.FromMilliseconds(damageThickDelay));
			}
		}

		private void DamagesTarget(Buff buff)
		{
			if (buff.Caster.TryGetSkill((SkillId)buff.NumArg2, out var skill))
			{
				var damageMultiplier = 1f;

				if (buff.Caster.TryGetBuff(BuffId.Zhendu_Buff, out var ZhenduBuff))
					damageMultiplier = ZhenduBuff.NumArg1;

				var skillHitResult = SCR_SkillHit(buff.Caster, buff.Target, skill);
				skillHitResult.Damage *= damageMultiplier;

				// The damage amount is unknow, for now we are dealing
				// the same amount as the original skill does
				buff.Target.TakeDamage(skillHitResult.Damage, buff.Caster);

				var hit = new HitInfo(buff.Caster, buff.Target, SkillId.Wugushi_JincanGu, skillHitResult.Damage, HitResultType.Buff12);

				Send.ZC_HIT_INFO(buff.Caster, buff.Target, hit);
			}
		}
	}
}
