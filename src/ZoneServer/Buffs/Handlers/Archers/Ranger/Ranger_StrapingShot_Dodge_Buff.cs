using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Archers.Ranger
{
	/// <summary>
	/// Buff handler for Strafe Dodge Buff, which increases evasion
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: None
	/// </remarks>
	[BuffHandler(BuffId.Ranger_StrapingShot_Dodge_Buff)]
	public class Ranger_StrapingShot_Dodge_Buff : BuffHandler
	{
		private const float DrBuffRateBase = 1f;
		private const float DrBuffRatePerLevel = 0.2f;

		/// <summary>
		/// Starts buff, increasing dodge rate.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			var target = buff.Target;

			var drBonus = target.Properties.GetFloat(PropertyName.DR) * (DrBuffRateBase + DrBuffRatePerLevel * buff.NumArg1);

			AddPropertyModifier(buff, buff.Target, PropertyName.DR_BM, drBonus);
		}

		/// <summary>
		/// Ends the buff, resetting dodge rate.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.DR_BM);
		}
	}
}
