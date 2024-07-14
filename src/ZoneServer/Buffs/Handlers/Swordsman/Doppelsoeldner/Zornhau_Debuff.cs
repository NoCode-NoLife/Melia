using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.SplashAreas;
using Yggdrasil.Logging;

namespace Melia.Zone.Buffs.Handlers.Swordsman.Doppelsoeldner
{
	/// <summary>
	/// Buff handler for Zornhau: Lasting Shock, which reduces Block and Evasion,
	/// and deals damage every 0.5 seconds
	/// </summary>
	[BuffHandler(BuffId.Zornhau_Debuff)]
	public class Zornhau_Debuff : BuffHandler
	{
		private const float BlkDebuffRate = 0.5f;
		private const float DrDebuffRate = 0.5f;

		/// <summary>
		/// Starts buff, reducing Block and Dodge
		/// </summary>
		/// <param name="buff"></param>
		public override void OnStart(Buff buff)
		{
			var target = buff.Target;

			var reduceBlk = target.Properties.GetFloat(PropertyName.BLK) * BlkDebuffRate;
			AddPropertyModifier(buff, buff.Target, PropertyName.BLK_BM, -reduceBlk);

			var reduceDr = target.Properties.GetFloat(PropertyName.DR) * DrDebuffRate;
			AddPropertyModifier(buff, buff.Target, PropertyName.DR_BM, -reduceDr);
		}

		/// <summary>
		/// Ends the buff, resetting the Int and Spr
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.BLK_BM);
			RemovePropertyModifier(buff, buff.Target, PropertyName.DR_BM);
		}

		/// <summary>
		/// Inflicts the damage over time effect, which deals damage every 0.5 seconds
		/// </summary>
		/// <param name="buff"></param>
		public override void WhileActive(Buff buff)
		{
			if (!buff.Target.IsDead)
			{
				buff.Target.TakeDamage(buff.NumArg2, buff.Caster);
				var hit = new HitInfo(buff.Caster, buff.Target, SkillId.Doppelsoeldner_Zornhau_Abil, buff.NumArg2, HitResultType.Hit);
				Send.ZC_HIT_INFO(buff.Caster, buff.Target, hit);
			}
		}
	}
}
