using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Common
{
	/// <summary>
	/// Buff handler for HeavyBleeding, which deals damage in regular intervals.
	/// </summary>
	[BuffHandler(BuffId.HeavyBleeding)]
	public class HeavyBleeding : BuffHandler
	{
		public override void WhileActive(Buff buff)
		{
			var attacker = buff.Caster;
			var target = buff.Target;
			var damage = buff.NumArg2;

			target.TakeSimpleHit(damage, attacker, SkillId.None);
		}
	}
}
