using Melia.Shared.Tos.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.Skills.Combat;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the VerminPot Debuff, which ticks damage every second.
	/// </summary>
	[BuffHandler(BuffId.Archer_VerminPot_Debuff)]
	public class Archer_VerminPot_Debuff : BuffHandler
	{
		public override void WhileActive(Buff buff)
		{
			// The damage amount is unknow, for now we are dealing
			// the same amount as the original skill hit Passed as NumberArg2
			buff.Target.TakeDamage(buff.NumArg2, buff.Caster);

			var hit = new HitInfo(buff.Caster, buff.Target, null, buff.NumArg2, HitResultType.Hit);
			hit.ForceId = ForceId.GetNew();

			Send.ZC_HIT_INFO(buff.Caster, buff.Target, null, hit);
		}
	}
}
