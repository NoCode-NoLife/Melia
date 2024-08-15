using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Buffs.Handlers.Archers.Wugushi
{
	/// <summary>
	/// Handle for the VerminPot Debuff (PoisonPot), which ticks damage every second.
	/// </summary>
	[BuffHandler(BuffId.Archer_VerminPot_Debuff)]
	public class Archer_VerminPot_Debuff : BuffHandler
	{
		public override void OnStart(Buff buff)
		{
			var damageThickDelay = buff.Data.UpdateTime;

			Crescendo_Bane_Buff.TryApply(buff.Caster, ref damageThickDelay);

			buff.UpdateTime = damageThickDelay;
		}

		public override void WhileActive(Buff buff)
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

				var hit = new HitInfo(buff.Caster, buff.Target, SkillId.Wugushi_ThrowGuPot, skillHitResult.Damage, HitResultType.Buff26);

				Send.ZC_HIT_INFO(buff.Caster, buff.Target, hit);
			}
		}
	}	
}
