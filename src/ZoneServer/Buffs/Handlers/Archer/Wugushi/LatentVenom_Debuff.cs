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
	/// Handle for the Latent Venom Debuff, which ticks damage every second.
	/// </summary>
	[BuffHandler(BuffId.LatentVenom_Debuff)]
	public class LatentVenom_Debuff : BuffHandler
	{
		public override async void WhileActive(Buff buff)
		{
			if (buff.Target.IsDead)
				return;

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

				var hit = new HitInfo(buff.Caster, buff.Target, SkillId.Wugushi_LatentVenom, skillHitResult.Damage, HitResultType.Buff26);

				Send.ZC_HIT_INFO(buff.Caster, buff.Target, hit);
			}

			var damageThickDelay = TimeSpan.FromMilliseconds(1000);

			Crescendo_Bane_Buff.TryApply(buff.Caster, ref damageThickDelay);
			await Task.Delay(damageThickDelay);
		}
	}
}
