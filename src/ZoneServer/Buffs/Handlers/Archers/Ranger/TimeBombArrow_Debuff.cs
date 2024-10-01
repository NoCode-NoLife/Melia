using System;
using System.Buffers;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Archers.Ranger;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Archers.Ranger
{
	/// <summary>
	/// Buff handler for TimeBombArrow_Debuff, which deals damage
	/// and knockdown when it expires
	/// </summary>
	/// <remarks>
	/// NumArg1: damage of original shot
	/// NumArg2: damage multiplier
	/// </remarks>
	[BuffHandler(BuffId.TimeBombArrow_Debuff)]
	public class TimeBombArrow_Debuff : BuffHandler
	{
		public override void OnEnd(Buff buff)
		{
			if (!buff.Target.IsDead)
			{
				var attacker = buff.Caster;
				var target = buff.Target;
				var damage = buff.NumArg1 * buff.NumArg2;
				if (attacker.TryGetSkill(SkillId.Ranger_TimeBombArrow, out var skill))
				{
					Send.ZC_NORMAL.PlayEffect(target, "F_archer_explosiontrap_hit_explosion", 1);

					// Note that this has to be a skill hit because it has knockdown
					// We do not do the usual calculation though as we already know
					// the damage and it can't miss or critical or anything
					SkillHitResult skillHitResult = new SkillHitResult();
					skillHitResult.Damage = damage;
					skillHitResult.Result = HitResultType.Hit;
					skillHitResult.HitCount = 1;
					target.TakeDamage(skillHitResult.Damage, attacker);

					var skillHit = new SkillHitInfo(attacker, target, skill, skillHitResult, TimeSpan.FromMilliseconds(200), TimeSpan.Zero);

					// The explosion hits nearby targets too.  The skillhandler handles that
					Ranger_TimeBombArrow.BombBlast(skill, attacker, target, buff.NumArg2);

					if (!attacker.IsAbilityActive(AbilityId.Ranger35)) {
						// Target gets blown backwards relative to their facing direction
						skillHit.KnockBackInfo = new KnockBackInfo(target.Position.GetRelative(target.Direction, 2f), target.Position, HitType.KnockDown, 150, 60);
						skillHit.ApplyKnockBack(target);
					}

					Send.ZC_SKILL_HIT_INFO(attacker, skillHit);
				}
			}
		}
	}
}
