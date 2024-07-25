using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Shared.Game.Const;
using Melia.Zone.World.Actors;
using System;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Virus Debuff, which ticks damage while active.
	/// </summary>
	[BuffHandler(BuffId.Virus_Debuff)]
	public class Virus_Debuff : BuffHandler
	{
		public override void WhileActive(Buff buff)
		{
			var target = buff.Target;

			if (target.Hp > 0)
			{
				// The damage amount is unknow, for now we are dealing
				// the same amount as the original skill hit, which is given as NumberArg2
				target.TakeDamage(buff.NumArg2, buff.Caster);
				var hit = new HitInfo(buff.Caster, target, SkillId.Wugushi_WugongGu, buff.NumArg2, HitResultType.Hit);

				Send.ZC_HIT_INFO(buff.Caster, target, hit);
			} else
			{
				var maxSpreadAmount = 5;

				// Only spreads to same faction as target
				foreach (var spreadTarget in target.Map.GetAttackableEntitiesInRange(buff.Caster, target.Position, 30).LimitRandom(maxSpreadAmount))
				{
					spreadTarget.StartBuff(BuffId.Virus_Debuff, buff.NumArg1, buff.NumArg2, TimeSpan.FromSeconds(10), buff.Caster);
				}
			}
		}
	}
}
