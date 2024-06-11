using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.Skills.Combat;
using Melia.Shared.Game.Const;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Wide Miasma Debuff, which ticks 4 times every second doing damage to the target.
	/// </summary>
	[BuffHandler(BuffId.WideMiasma_Debuff)]
	public class WideMiasma_Debuff : BuffHandler
	{
		public override void WhileActive(Buff buff)
		{
			var casterCharacter = buff.Caster as Character;

			if (casterCharacter != null)
			{
				if (buff.Target.IsDead)
				{
					return;
				}

				// The damage amount is unknow, for now we are dealing
				// the same amount as the original skill hit is passed as NumberArg2
				buff.Target.TakeDamage(buff.NumArg2, casterCharacter);

				var hit = new HitInfo(casterCharacter, buff.Target, null, buff.NumArg2, HitResultType.Hit);

				Send.ZC_HIT_INFO(casterCharacter, buff.Target, null, hit);
			}
		}
	}
}
