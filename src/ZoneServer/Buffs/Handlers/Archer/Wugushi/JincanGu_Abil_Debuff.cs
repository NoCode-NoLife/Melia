using System;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;

namespace Melia.Zone.Buffs.Handlers.Archer.Wugushi
{
	/// <summary>
	/// Handle for the JincanGu Debuff (GoldenFrog), which ticks damage every second.
	/// </summary>
	[BuffHandler(BuffId.JincanGu_Abil_Debuff)]
	public class JincanGu_Abil_Debuff : BuffHandler
	{
		private const string AdditionalHits = "Wugushi.JincanGu_Abil_Debuff";

		public override async void OnStart(Buff buff)
		{
			buff.Vars.SetInt(AdditionalHits, 5);
		}

		public override async void WhileActive(Buff buff)
		{
			if (buff.Target.IsDead)
				return;

			// The damage amount is unknow, for now we are dealing
			// the same amount as the original skill hit is passed as NumberArg2
			buff.Target.TakeDamage(buff.NumArg2, buff.Caster);
			var hit = new HitInfo(buff.Caster, buff.Target, SkillId.Wugushi_ThrowGuPot, buff.NumArg2, HitResultType.Buff12);
			Send.ZC_HIT_INFO(buff.Caster, buff.Target, hit);

			// We are Damaging 5x additional hits
			if (buff.Vars.GetInt(AdditionalHits) <= 5 && buff.Vars.GetInt(AdditionalHits) >= 1)
			{
				await Task.Delay(TimeSpan.FromSeconds(1));

				var remaningAdditionalHits = buff.Vars.GetInt(AdditionalHits);
				buff.Vars.SetInt(AdditionalHits, remaningAdditionalHits - 2);

				buff.Target.TakeDamage(buff.NumArg2, buff.Caster);
				var hit2 = new HitInfo(buff.Caster, buff.Target, SkillId.Wugushi_ThrowGuPot, buff.NumArg2, HitResultType.Buff12);
				Send.ZC_HIT_INFO(buff.Caster, buff.Target, hit2);

				await Task.Delay(TimeSpan.FromSeconds(1));
			} else
			{
				await Task.Delay(TimeSpan.FromSeconds(2));
			}
		}
	}
}
