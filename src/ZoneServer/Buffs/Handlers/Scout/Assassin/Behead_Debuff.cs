using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.World.Actors;

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

				target.TakeSimpleHit(damage, attacker, SkillId.Assassin_Behead_DOT);
			}
		}
	}
}
