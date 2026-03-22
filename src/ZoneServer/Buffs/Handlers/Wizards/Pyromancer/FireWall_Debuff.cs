using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Wizards.Pyromancer
{
	/// <summary>
	/// Handler for the Fire Wall debuff, which reduces fire resistance.
	/// </summary>
	[BuffHandler(BuffId.FireWall_Debuff)]
	public class FireWall_Debuff : BuffHandler
	{
		/// <summary>
		/// The amount by which the target's fire resistance is reduced.
		/// </summary>
		/// <remarks>
		/// This value is used as part of a percentage based multiplier.
		/// A reduction of 10 effectively means the target takes 10% more
		/// fire damage.
		/// </remarks>
		public const float ResistanceReduction = 10;

		/// <summary>
		/// Reduces the target's fire resistance when the buff starts.
		/// </summary>
		/// <param name="buff"></param>
		/// <param name="activationType"></param>
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			if (activationType != ActivationType.Start)
				return;

			// There appear to be no unified resistance properties,
			// especially of the _BM variety, so we'll choose based
			// on which base property is available to handle both
			// characters and monsters.

			if (buff.Target.Properties.Has(PropertyName.ResFire))
				AddPropertyModifier(buff, buff.Target, PropertyName.ResFire_BM, -ResistanceReduction);
			else if (buff.Target.Properties.Has(PropertyName.Fire_Def))
				AddPropertyModifier(buff, buff.Target, PropertyName.Fire_Def_BM, -ResistanceReduction);
		}

		/// <summary>
		/// Removes the fire resistance reduction when the buff ends.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.ResFire_BM);
			RemovePropertyModifier(buff, buff.Target, PropertyName.Fire_Def_BM);
		}
	}
}
