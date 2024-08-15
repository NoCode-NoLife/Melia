using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Common
{
	/// <summary>
	/// Buff handler for Fire, which deals damage in regular intervals.
	/// </summary>
	[BuffHandler(BuffId.Fire)]
	public class Fire : BuffHandler
	{
		public override void WhileActive(Buff buff)
		{
			if (buff.Target.IsDead)
				return;

			var attacker = buff.Caster;
			var target = buff.Target;
			var damage = buff.NumArg2;

			target.TakeSimpleHit(damage, attacker, SkillId.None);
		}
	}
}
