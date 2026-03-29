using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Wizards.Pyromancer
{
	/// <summary>
	/// Handler for the Fire Wall buff, which increases fire damage.
	/// </summary>
	/// <remarks>
	/// NumArg1: Ability Level
	/// NumArg2: None
	/// </remarks>
	[BuffHandler(BuffId.FireWall_Buff)]
	public class FireWall_Buff : BuffHandler
	{
		/// <summary>
		/// Adds the fire damage bonus when the buff starts.
		/// </summary>
		/// <param name="buff"></param>
		/// <param name="activationType"></param>
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			if (activationType != ActivationType.Start)
				return;

			var abilityLevel = buff.NumArg1;
			var stat = buff.Caster.Properties.GetFloat(PropertyName.INT);
			var bonus = (stat / 5f) * abilityLevel;

			AddPropertyModifier(buff, buff.Target, PropertyName.Fire_Atk_BM, bonus);
		}

		/// <summary>
		/// Removes the fire damage bonus when the buff ends.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.Fire_Atk_BM);
		}
	}
}
