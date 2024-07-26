using System;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;

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

			// The damage amount is unknow, for now we are dealing
			// the same amount as the original skill hit is passed as NumberArg2
			buff.Target.TakeDamage(buff.NumArg2, buff.Caster);

			var hit = new HitInfo(buff.Caster, buff.Target, SkillId.Wugushi_LatentVenom, buff.NumArg2, HitResultType.Buff26);

			Send.ZC_HIT_INFO(buff.Caster, buff.Target, hit);

			await Task.Delay(TimeSpan.FromSeconds(1));
		}
	}
}
