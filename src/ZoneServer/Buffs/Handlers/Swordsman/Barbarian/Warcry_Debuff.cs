using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Swordsman.Highlander
{
	/// <summary>
	/// Handler for CrownArmor_Debuff, which reduces PAtk
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: Unused
	/// </remarks>
	[BuffHandler(BuffId.Warcry_Debuff)]
	public class Warcry_Debuff : BuffHandler
	{
		private const float PAtkPenaltyBase = 0.055f;
		private const float PAtkPenaltyPerLevel = 0.005f;

		/// <summary>
		/// Starts buff, reducing PAtk
		/// </summary>
		/// <param name="buff"></param>
		public override void OnStart(Buff buff)
		{
			var target = buff.Target;
			var reducePatk = target.Properties.GetFloat(PropertyName.PATK) * (PAtkPenaltyBase + buff.NumArg1 * PAtkPenaltyPerLevel);

			AddPropertyModifier(buff, target, PropertyName.PATK_BM, -reducePatk);
		}

		/// <summary>
		/// Ends the buff, resetting PAtk.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.PATK_BM);
		}
	}
}
