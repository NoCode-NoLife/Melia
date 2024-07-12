using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;

namespace Melia.Zone.Buffs.Handlers.Scout.Assassin
{
	/// <summary>
	/// Buff handler for Behead: Bleeding, which deals damage in regular intervals.
	/// </summary>
	[BuffHandler(BuffId.Behead_Debuff)]
	public class Behead_Debuff : BuffHandler
	{
		public override void WhileActive(Buff buff)
		{
			if (!buff.Target.IsDead)
			{
				var attacker = buff.Caster;
				var target = buff.Target;
				var damage = buff.NumArg2;

				target.TakeDamage(damage, attacker);

				var hit = new HitInfo(attacker, target, null, damage, HitResultType.Hit);
				Send.ZC_HIT_INFO(attacker, target, SkillId.Assassin_Behead_DOT, hit);
			}
		}
	}
}
