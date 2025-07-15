using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Swordsmen.Doppelsoeldner
{
	/// <summary>
	/// Buff handler for Zornhau: Lasting Shock, which reduces Block and Evasion,
	/// and deals damage to yourself on each buff tick.
	/// </summary>
	[BuffHandler(BuffId.Zornhau_Debuff)]
	public class Zornhau_Debuff : BuffHandler
	{
		private const float BlkDebuffRate = 0.5f;
		private const float DrDebuffRate = 0.5f;

		/// <summary>
		/// Starts buff, reducing Block and Dodge.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			var target = buff.Target;

			var reduceBlk = target.Properties.GetFloat(PropertyName.BLK) * BlkDebuffRate;
			var reduceDr = target.Properties.GetFloat(PropertyName.DR) * DrDebuffRate;

			AddPropertyModifier(buff, buff.Target, PropertyName.BLK_BM, -reduceBlk);
			AddPropertyModifier(buff, buff.Target, PropertyName.DR_BM, -reduceDr);
		}

		/// <summary>
		/// Ends the buff, resetting Block and Dodge.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.BLK_BM);
			RemovePropertyModifier(buff, buff.Target, PropertyName.DR_BM);
		}

		/// <summary>
		/// Inflicts the damage over time effect, which deals damage in regular
		/// intervals.
		/// </summary>
		/// <param name="buff"></param>
		public override void WhileActive(Buff buff)
		{
			var attacker = buff.Caster;
			var target = buff.Target;
			var damage = buff.NumArg2;

			target.TakeSimpleHit(damage, attacker, SkillId.Doppelsoeldner_Zornhau_Abil);
		}
	}
}
