using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Common
{
	/// <summary>
	/// Handler for Armor Break, which zeroes defense.
	/// </summary>
	[BuffHandler(BuffId.UC_armorbreak)]
	public class UC_armorbreak : BuffHandler
	{
		/// <summary>
		/// Starts buff, zeroing defense.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnStart(Buff buff)
		{
			var target = buff.Target;
			var reduceDef = target.Properties.GetFloat(PropertyName.DEF);

			AddPropertyModifier(buff, target, PropertyName.DEF_BM, -reduceDef);
		}

		/// <summary>
		/// Ends the buff, resetting defense.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.DEF_BM);
		}
	}
}
